﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
  [TestClass]
  public class UnitTestAssembler
  {
    [TestMethod]
    public void TestOverlappingSegmentWarning()
    {
      string      source = @"* = $2000

                             !fill 256
                             * = $20fe
                             rts";

      C64Studio.Parser.ASMFileParser      parser = new C64Studio.Parser.ASMFileParser();
      parser.SetAssemblerType( C64Studio.Types.AssemblerType.C64_STUDIO );

      C64Studio.Parser.CompileConfig config = new C64Studio.Parser.CompileConfig();
      config.OutputFile = "test.prg";
      config.TargetType = C64Studio.Types.CompileTargetType.PRG;
      config.Assembler = C64Studio.Types.AssemblerType.C64_STUDIO;

      Assert.IsTrue( parser.Parse( source, null, config ) );

      Assert.IsTrue( parser.Assemble( config ) );

      var assembly = parser.Assembly;

      Assert.AreEqual( 1, parser.Warnings );
      Assert.AreEqual( C64Studio.Parser.ParserBase.ParseMessage.LineType.SEVERE_WARNING, parser.Messages.Values[0].Type  );
      Assert.AreEqual( C64Studio.Types.ErrorCode.W0001_SEGMENT_OVERLAP, parser.Messages.Values[0].Code );

      Assert.AreEqual( "002000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006000", assembly.ToString() );
    }



    [TestMethod]
    public void TestPotentialWarningForIndirectJMP()
    {
      string      source = @"* = $2000

                             JUMP_ADDRESS = $3fff

                             jmp (JUMP_ADDRESS )";

      C64Studio.Parser.ASMFileParser      parser = new C64Studio.Parser.ASMFileParser();
      parser.SetAssemblerType( C64Studio.Types.AssemblerType.C64_STUDIO );

      C64Studio.Parser.CompileConfig config = new C64Studio.Parser.CompileConfig();
      config.OutputFile = "test.prg";
      config.TargetType = C64Studio.Types.CompileTargetType.PRG;
      config.Assembler = C64Studio.Types.AssemblerType.C64_STUDIO;

      Assert.IsTrue( parser.Parse( source, null, config ) );

      Assert.IsTrue( parser.Assemble( config ) );

      var assembly = parser.Assembly;

      Assert.AreEqual( 1, parser.Warnings );
      Assert.AreEqual( C64Studio.Parser.ParserBase.ParseMessage.LineType.WARNING, parser.Messages.Values[0].Type );
      Assert.AreEqual( C64Studio.Types.ErrorCode.W0007_POTENTIAL_PROBLEM, parser.Messages.Values[0].Code );

      Assert.AreEqual( "00206CFF3F", assembly.ToString() );
    }



    [TestMethod]
    public void TestPotentialWarningForIndirectJMPWithLateEvaluation()
    {
      string      source = @"* = $2000

                             jmp (JUMP_ADDRESS )

                            JUMP_ADDRESS = $3fff";

      C64Studio.Parser.ASMFileParser      parser = new C64Studio.Parser.ASMFileParser();
      parser.SetAssemblerType( C64Studio.Types.AssemblerType.C64_STUDIO );

      C64Studio.Parser.CompileConfig config = new C64Studio.Parser.CompileConfig();
      config.OutputFile = "test.prg";
      config.TargetType = C64Studio.Types.CompileTargetType.PRG;
      config.Assembler = C64Studio.Types.AssemblerType.C64_STUDIO;

      Assert.IsTrue( parser.Parse( source, null, config ) );

      Assert.IsTrue( parser.Assemble( config ) );

      var assembly = parser.Assembly;

      Assert.AreEqual( 1, parser.Warnings );
      Assert.AreEqual( C64Studio.Parser.ParserBase.ParseMessage.LineType.WARNING, parser.Messages.Values[0].Type );
      Assert.AreEqual( C64Studio.Types.ErrorCode.W0007_POTENTIAL_PROBLEM, parser.Messages.Values[0].Code );

      Assert.AreEqual( "00206CFF3F", assembly.ToString() );
    }

  }
}
