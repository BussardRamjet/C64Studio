﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C64Studio.Formats
{
  /*
  File Header, 20 bytes...

  ID          [00-02]    3 bytes  : ASCII ID string... "CTM"
  VERSION     [03]       1 byte   : version number, currently $04.
  COLOURS     [04-07]    4 bytes  : BGR, MC1, MC2, RAM.
  COLOUR_MODE [08]       1 byte   : 0 = Global, 1 = Per Tile, 2 = Per Tile Cell.
  VIC_RES     [09]       1 byte   : 0 = Hi Resolution, 1 = Multicolour.


  NUM_CHARS   [10,11]    2 bytes  : 16-bits, Number of chars - 1 (low, high).


  NUM_TILES   [12]       1 byte   : Number of tiles - 1.


  TILE_WID    [13]       1 byte   : Tile Width
  TILE_HEI    [14]       1 byte   : Tile Height


  MAP_WID     [15,16]    2 bytes  : 16-bit Map width (low, high).
  MAP_HEI     [17,18]    2 bytes  : 16-bit Map height (low, high).


  EXPANDED    [19]       1 byte   : Boolean flag, 1 = CHAR_DATA is in "Expanded" form (CELL_DATA is unnecessary and absent).


  RESERVED    [20]       1 byte   
  RESERVED    [21]       1 byte
  RESERVED    [22]       1 byte
  RESERVED    [23]       1 byte   : (total header size is 24 bytes)

   CHAR_DATA.      The character set. Size = NUM_CHARS * 8 bytes.


   NB. NUM_CHARS should equal NUM_TILES * TILE_SIZE * TILE_SIZE for an "Expanded" char-set.

  CHAR_ATTRIBS.   1 byte for each character in the set.


          Each byte should be interpreted as follows...  
                
          MMMMCCCC, where M is one of 4 material bits, C is one of 4 colour bits.    


          The CHAR_ATTRIBS block is new to CTM v4, CharPad generates this information when a charset is 
          compressed from an expanded state.
            
             
     CELL_DATA.      Size = NUM_TILES * TILE_SIZE * TILE_SIZE bytes * 2 bytes. (only exists if CHAR_DATA is not "Expanded")
     CELL_ATTRIBS.   Size = NUM_TILES * TILE_SIZE * TILE_SIZE bytes (exists for ALL modes)
                  
          1 attribute byte for each cell of each tile. 
                  
          Upper 4 bits = cell Material value (0-15)
          Lower 4 bits = cell "Colour RAM" value (0-15)    nb. only when COLOUR_MODE = 2 (Per Tile Cell)


          NB. CELL_ATTRIBS is a stream of 8-bit attribute codes arranged left-to-right, top-to-bottom for each tile.




  TILE_ATTRIBS.   Size = NUM_TILES bytes (1 byte per tile = "RAM colour". only exists if COLOR_MODE = 1 (Per Tile)




  MAP_DATA.        Size =  MAP_WID x MAP_HEI bytes.
  */

  public class CharpadProject
  {
    public enum ColorMode
    {
      GLOBAL = 0,
      PER_TILE = 1,
      PER_TILE_CELL = 2
    };

    public class SingleChar
    {
      public GR.Memory.ByteBuffer     Data = new GR.Memory.ByteBuffer( 8 );
      public int                      Color = 1;
    };

    public class Tile
    {
      public GR.Memory.ByteBuffer     CharData = new GR.Memory.ByteBuffer();
      public GR.Memory.ByteBuffer     ColorData = new GR.Memory.ByteBuffer();
    };


    public int                    BackgroundColor = 0;
    public int                    MultiColor1 = 8;
    public int                    MultiColor2 = 9;
    public int                    CustomColor = 1;
    public bool                   MultiColor = true;

    public int                    NumChars = 0;
    public int                    NumTiles = 0;
    public int                    TileWidth = 2;
    public int                    TileHeight = 2;
    public int                    MapWidth = 0;
    public int                    MapHeight = 0;
    public ColorMode              TileColorMode = ColorMode.GLOBAL;

    public List<SingleChar>       Characters = new List<SingleChar>();
    public List<Tile>             Tiles = new List<Tile>();
    public GR.Memory.ByteBuffer   MapData = new GR.Memory.ByteBuffer();



    public bool LoadFromFile( GR.Memory.ByteBuffer Data )
    {
      Characters.Clear();
      MapData.Clear();

      if ( ( Data == null )
      ||   ( Data.Length < 24 )
      ||   ( Data.ByteAt( 0 ) != 'C' )
      ||   ( Data.ByteAt( 1 ) != 'T' )
      ||   ( Data.ByteAt( 2 ) != 'M' ) )
      {
        // not a valid CTM file
        return false;
      }
      int version = Data.ByteAt( 3 );
      if ( version != 4 )
      {
        System.Windows.Forms.MessageBox.Show( "Currently only version 4 of Charpad project files is supported. Sorry!", "Unsupported version " + version );
        return false;
      }

      BackgroundColor = Data.ByteAt( 4 );
      MultiColor1     = Data.ByteAt( 5 );
      MultiColor2     = Data.ByteAt( 6 );
      CustomColor     = Data.ByteAt( 7 );
      TileColorMode = (ColorMode)Data.ByteAt( 8 );
      MultiColor      = ( Data.ByteAt( 9 ) != 0 );

      NumChars    = Data.UInt16At( 10 ) + 1;
      NumTiles    = Data.ByteAt( 12 ) + 1;
      TileWidth   = Data.ByteAt( 13 );
      TileHeight  = Data.ByteAt( 14 );

      MapWidth    = Data.UInt16At( 15 );
      MapHeight   = Data.UInt16At( 17 );

      bool isExpanded = ( Data.ByteAt( 19 ) != 0 );

      int offsetToCharAttribs = 24 + NumChars * 8;

      for ( int charIndex = 0; charIndex < NumChars; ++charIndex )
      {
        SingleChar    newChar = new SingleChar();
        newChar.Data = Data.SubBuffer( 24 + charIndex * 8, 8 );
        newChar.Color = Data.ByteAt( offsetToCharAttribs + charIndex ) & 0x0f;

        Characters.Add( newChar );
      }

      for ( int i = 0; i < NumTiles; ++i )
      {
        Tile tile = new Tile();

        tile.CharData.Resize( (uint)( TileWidth * TileHeight * 2 ) );
        tile.ColorData.Resize( (uint)( TileWidth * TileHeight ) );

        Tiles.Add( tile );
      }

      if ( isExpanded )
      {
        byte curCharIndex = 0;
        for ( int i = 0; i < NumTiles; ++i )
        {
          for ( int j = 0; j < TileWidth * TileHeight; ++j )
          {
            Tiles[i].CharData.SetU16At( j * 2, curCharIndex );
            ++curCharIndex;
          }
        }
      }
      else
      {
        // CELL_DATA.      Size = NUM_TILES * TILE_SIZE * TILE_SIZE bytes * 2 bytes. (only exists if CHAR_DATA is not "Expanded")
        int offsetCellData = 24 + NumChars * 8 + NumChars;
        for ( int i = 0; i < NumTiles; ++i )
        {
          for ( int j = 0; j < TileWidth * TileHeight; ++j )
          {
            Tiles[i].CharData.SetU16At( j * 2, Data.UInt16At( offsetCellData + i * TileWidth * TileHeight * 2 + j * 2 ) );
          }
        }
      }
      // CELL_ATTRIBS.   Size = NUM_TILES * TILE_SIZE * TILE_SIZE bytes (exists for ALL modes)

      int offsetCellAttribs = 24 + NumChars * 8 + NumChars;
      if ( !isExpanded )
      {
        offsetCellAttribs += NumTiles * TileWidth * TileHeight * 2;
      }
      for ( int i = 0; i < NumTiles; ++i )
      {
        for ( int y = 0; y < TileHeight; ++y )
        {
          for ( int x = 0; x < TileWidth; ++x )
          {
            if ( TileColorMode == ColorMode.PER_TILE_CELL )
            {
              Tiles[i].ColorData.SetU8At( x + y * TileWidth, (byte)( Data.ByteAt( offsetCellAttribs + i * TileWidth * TileHeight + x + y * TileHeight ) & 0x0f ) );
            }
            else
            {
              Tiles[i].ColorData.SetU8At( x + y * TileWidth, (byte)CustomColor );
            }
          }
        }
      }

      // TILE_ATTRIBS.   Size = NUM_TILES bytes (1 byte per tile = "RAM colour". only exists if COLOR_MODE = 1 (Per Tile)
      int   offsetTileAttribs = offsetCellAttribs + NumTiles * TileWidth * TileHeight;
      if ( TileColorMode == ColorMode.PER_TILE )
      {
        for ( int i = 0; i < NumTiles; ++i )
        {
          for ( int y = 0; y < TileHeight; ++y )
          {
            for ( int x = 0; x < TileWidth; ++x )
            {
              Tiles[i].ColorData.SetU8At( x + y * TileWidth, (byte)( Data.ByteAt( offsetTileAttribs + i ) & 0x0f ) );
            }
          }
        }
      }

      /*
      if ( TileColorMode == ColorMode.PER_TILE_CELL )
      {
        for ( int i = 0; i < NumTiles; ++i )
        {
          for ( int y = 0; y < TileHeight; ++y )
          {
            for ( int x = 0; x < TileWidth; ++x )
            {
              Tiles[i].ColorData.SetU8At( x + y * TileWidth, (byte)( Data.ByteAt( offsetCellAttribs + i * TileWidth * TileHeight + x + y * TileHeight ) & 0x0f ) );
            }
          }
        }
      }*/

      // MAP_DATA.        Size =  MAP_WID x MAP_HEI bytes.
      int offsetMapData = offsetTileAttribs;
      if ( TileColorMode == ColorMode.PER_TILE )
      {
        offsetMapData += NumTiles;
      }

      MapData = Data.SubBuffer( offsetMapData, MapWidth * MapHeight );
      return true;
    }

  }
}
