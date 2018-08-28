using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pastebin.Properties;

namespace Pastebin
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> _languageMap { get; }
        private Dictionary<string, string> _expirationDictionary { get; }
        private Dictionary<string, int> _accessDictionary { get; }
        private bool _loggedIn;
        private readonly Settings _settings = Settings.Default;


        public MainForm()
        {
            _languageMap = new Dictionary<string, string>();
            _expirationDictionary = new Dictionary<string, string>
            {
                { "Never", "N" },
                { "10 Minutes", "10M" },
                { "1 Hour", "1H" },
                { "1 Day", "1D" },
                { "1 Week", "1W" },
                { "2 Weeks", "2W" },
                { "1 Month", "1M" },
                { "6 Months", "6M" },
                { "1 Year", "1Y" }
            };
            _accessDictionary = new Dictionary<string, int>
            {
                { "Public", 0 },
                { "Unlisted", 1 },
                { "Private", 2 }
            };

            _loggedIn = string.IsNullOrEmpty(_settings.__userKey);


            InitializeComponent();
            SetLanguages();

            foreach(string s in _languageMap.Keys)
            {
                comboBoxSyntax.Items.Add(s);
            }

            foreach (string s in _accessDictionary.Keys)
            {
                comboBoxExposure.Items.Add(s);
            }

            foreach (string s in _expirationDictionary.Keys)
            {
                comboBoxExpiration.Items.Add(s);
            }
        }

        private void SetLanguages()
        {
            _languageMap["4CS"] = "4cs";
            _languageMap["6502 ACME Cross Assembler"] = "6502acme";
            _languageMap["6502 Kick Assembler"] = "6502kickass";
            _languageMap["6502 TASM/64TASS"] = "6502tasm";
            _languageMap["ABAP"] = "abap";
            _languageMap["ActionScript"] = "actionscript";
            _languageMap["ActionScript 3"] = "actionscript3";
            _languageMap["Ada"] = "ada";
            _languageMap["AIMMS"] = "aimms";
            _languageMap["ALGOL 68"] = "algol68";
            _languageMap["Apache Log"] = "apache";
            _languageMap["AppleScript"] = "applescript";
            _languageMap["APT Sources"] = "apt_sources";
            _languageMap["ARM"] = "arm";
            _languageMap["ASM (NASM)"] = "asm";
            _languageMap["ASP"] = "asp";
            _languageMap["Asymptote"] = "asymptote";
            _languageMap["autoconf"] = "autoconf";
            _languageMap["Autohotkey"] = "autohotkey";
            _languageMap["AutoIt"] = "autoit";
            _languageMap["Avisynth"] = "avisynth";
            _languageMap["Awk"] = "awk";
            _languageMap["BASCOM AVR"] = "bascomavr";
            _languageMap["Bash"] = "bash";
            _languageMap["Basic4GL"] = "basic4gl";
            _languageMap["Batch"] = "dos";
            _languageMap["BibTeX"] = "bibtex";
            _languageMap["Blitz Basic"] = "blitzbasic";
            _languageMap["Blitz3D"] = "b3d";
            _languageMap["BlitzMax"] = "bmx";
            _languageMap["BNF"] = "bnf";
            _languageMap["BOO"] = "boo";
            _languageMap["BrainFuck"] = "bf";
            _languageMap["C"] = "c";
            _languageMap["C (WinAPI)"] = "c_winapi";
            _languageMap["C for Macs"] = "c_mac";
            _languageMap["C Intermediate Language"] = "cil";
            _languageMap["C#"] = "csharp";
            _languageMap["C++"] = "cpp";
            _languageMap["C++ (WinAPI)"] = "cpp-winapi";
            _languageMap["C++ (with Qt extensions)"] = "cpp-qt";
            _languageMap["C: Loadrunner"] = "c_loadrunner";
            _languageMap["CAD DCL"] = "caddcl";
            _languageMap["CAD Lisp"] = "cadlisp";
            _languageMap["Ceylon"] = "ceylon";
            _languageMap["CFDG"] = "cfdg";
            _languageMap["ChaiScript"] = "chaiscript";
            _languageMap["Chapel"] = "chapel";
            _languageMap["Clojure"] = "clojure";
            _languageMap["Clone C"] = "klonec";
            _languageMap["Clone C++"] = "klonecpp";
            _languageMap["CMake"] = "cmake";
            _languageMap["COBOL"] = "cobol";
            _languageMap["CoffeeScript"] = "coffeescript";
            _languageMap["ColdFusion"] = "cfm";
            _languageMap["CSS"] = "css";
            _languageMap["Cuesheet"] = "cuesheet";
            _languageMap["D"] = "d";
            _languageMap["Dart"] = "dart";
            _languageMap["DCL"] = "dcl";
            _languageMap["DCPU-16"] = "dcpu16";
            _languageMap["DCS"] = "dcs";
            _languageMap["Delphi"] = "delphi";
            _languageMap["Delphi Prism (Oxygene)"] = "oxygene";
            _languageMap["Diff"] = "diff";
            _languageMap["DIV"] = "div";
            _languageMap["DOT"] = "dot";
            _languageMap["E"] = "e";
            _languageMap["Easytrieve"] = "ezt";
            _languageMap["ECMAScript"] = "ecmascript";
            _languageMap["Eiffel"] = "eiffel";
            _languageMap["Email"] = "email";
            _languageMap["EPC"] = "epc";
            _languageMap["Erlang"] = "erlang";
            _languageMap["Euphoria"] = "euphoria";
            _languageMap["F#"] = "fsharp";
            _languageMap["Falcon"] = "falcon";
            _languageMap["Filemaker"] = "filemaker";
            _languageMap["FO Language"] = "fo";
            _languageMap["Formula One"] = "f1";
            _languageMap["Fortran"] = "fortran";
            _languageMap["FreeBasic"] = "freebasic";
            _languageMap["FreeSWITCH"] = "freeswitch";
            _languageMap["GAMBAS"] = "gambas";
            _languageMap["Game Maker"] = "gml";
            _languageMap["GDB"] = "gdb";
            _languageMap["Genero"] = "genero";
            _languageMap["Genie"] = "genie";
            _languageMap["GetText"] = "gettext";
            _languageMap["Go"] = "go";
            _languageMap["Groovy"] = "groovy";
            _languageMap["GwBasic"] = "gwbasic";
            _languageMap["Haskell"] = "haskell";
            _languageMap["Haxe"] = "haxe";
            _languageMap["HicEst"] = "hicest";
            _languageMap["HQ9 Plus"] = "hq9plus";
            _languageMap["HTML"] = "html4strict";
            _languageMap["HTML 5"] = "html5";
            _languageMap["Icon"] = "icon";
            _languageMap["IDL"] = "idl";
            _languageMap["INI file"] = "ini";
            _languageMap["Inno Script"] = "inno";
            _languageMap["INTERCAL"] = "intercal";
            _languageMap["IO"] = "io";
            _languageMap["ISPF Panel Definition"] = "ispfpanel";
            _languageMap["J"] = "j";
            _languageMap["Java"] = "java";
            _languageMap["Java 5"] = "java5";
            _languageMap["JavaScript"] = "javascript";
            _languageMap["JCL"] = "jcl";
            _languageMap["jQuery"] = "jquery";
            _languageMap["JSON"] = "json";
            _languageMap["Julia"] = "julia";
            _languageMap["KiXtart"] = "kixtart";
            _languageMap["Kotlin"] = "kotlin";
            _languageMap["Latex"] = "latex";
            _languageMap["LDIF"] = "ldif";
            _languageMap["Liberty BASIC"] = "lb";
            _languageMap["Linden Scripting"] = "lsl2";
            _languageMap["Lisp"] = "lisp";
            _languageMap["LLVM"] = "llvm";
            _languageMap["Loco Basic"] = "locobasic";
            _languageMap["Logtalk"] = "logtalk";
            _languageMap["LOL Code"] = "lolcode";
            _languageMap["Lotus Formulas"] = "lotusformulas";
            _languageMap["Lotus Script"] = "lotusscript";
            _languageMap["LScript"] = "lscript";
            _languageMap["Lua"] = "lua";
            _languageMap["M68000 Assembler"] = "m68k";
            _languageMap["MagikSF"] = "magiksf";
            _languageMap["Make"] = "make";
            _languageMap["MapBasic"] = "mapbasic";
            _languageMap["Markdown"] = "markdown";
            _languageMap["MatLab"] = "matlab";
            _languageMap["mIRC"] = "mirc";
            _languageMap["MIX Assembler"] = "mmix";
            _languageMap["Modula 2"] = "modula2";
            _languageMap["Modula 3"] = "modula3";
            _languageMap["Motorola 68000 HiSoft Dev"] = "68000devpac";
            _languageMap["MPASM"] = "mpasm";
            _languageMap["MXML"] = "mxml";
            _languageMap["MySQL"] = "mysql";
            _languageMap["Nagios"] = "nagios";
            _languageMap["NetRexx"] = "netrexx";
            _languageMap["newLISP"] = "newlisp";
            _languageMap["Nginx"] = "nginx";
            _languageMap["Nim"] = "nim";
            _languageMap["None"] = "text";
            _languageMap["NullSoft Installer"] = "nsis";
            _languageMap["Oberon 2"] = "oberon2";
            _languageMap["Objeck Programming Language"] = "objeck";
            _languageMap["Objective C"] = "objc";
            _languageMap["OCalm Brief"] = "ocaml-brief";
            _languageMap["OCaml"] = "ocaml";
            _languageMap["Octave"] = "octave";
            _languageMap["Open Object Rexx"] = "oorexx";
            _languageMap["OpenBSD PACKET FILTER"] = "pf";
            _languageMap["OpenGL Shading"] = "glsl";
            _languageMap["Openoffice BASIC"] = "oobas";
            _languageMap["Oracle 11"] = "oracle11";
            _languageMap["Oracle 8"] = "oracle8";
            _languageMap["Oz"] = "oz";
            _languageMap["ParaSail"] = "parasail";
            _languageMap["PARI/GP"] = "parigp";
            _languageMap["Pascal"] = "pascal";
            _languageMap["Pawn"] = "pawn";
            _languageMap["PCRE"] = "pcre";
            _languageMap["Per"] = "per";
            _languageMap["Perl"] = "perl";
            _languageMap["Perl 6"] = "perl6";
            _languageMap["PHP"] = "php";
            _languageMap["PHP Brief"] = "php-brief";
            _languageMap["Pic 16"] = "pic16";
            _languageMap["Pike"] = "pike";
            _languageMap["Pixel Bender"] = "pixelbender";
            _languageMap["PL/I"] = "pli";
            _languageMap["PL/SQL"] = "plsql";
            _languageMap["PostgreSQL"] = "postgresql";
            _languageMap["PostScript"] = "postscript";
            _languageMap["POV-Ray"] = "povray";
            _languageMap["PowerBuilder"] = "powerbuilder";
            _languageMap["PowerShell"] = "powershell";
            _languageMap["ProFTPd"] = "proftpd";
            _languageMap["Progress"] = "progress";
            _languageMap["Prolog"] = "prolog";
            _languageMap["Properties"] = "properties";
            _languageMap["ProvideX"] = "providex";
            _languageMap["Puppet"] = "puppet";
            _languageMap["PureBasic"] = "purebasic";
            _languageMap["PyCon"] = "pycon";
            _languageMap["Python"] = "python";
            _languageMap["Python for S60"] = "pys60";
            _languageMap["q/kdb+"] = "q";
            _languageMap["QBasic"] = "qbasic";
            _languageMap["QML"] = "qml";
            _languageMap["R"] = "rsplus";
            _languageMap["Racket"] = "racket";
            _languageMap["Rails"] = "rails";
            _languageMap["RBScript"] = "rbs";
            _languageMap["REBOL"] = "rebol";
            _languageMap["REG"] = "reg";
            _languageMap["Rexx"] = "rexx";
            _languageMap["Robots"] = "robots";
            _languageMap["RPM Spec"] = "rpmspec";
            _languageMap["Ruby"] = "ruby";
            _languageMap["Ruby Gnuplot"] = "gnuplot";
            _languageMap["Rust"] = "rust";
            _languageMap["SAS"] = "sas";
            _languageMap["Scala"] = "scala";
            _languageMap["Scheme"] = "scheme";
            _languageMap["Scilab"] = "scilab";
            _languageMap["SCL"] = "scl";
            _languageMap["SdlBasic"] = "sdlbasic";
            _languageMap["Smalltalk"] = "smalltalk";
            _languageMap["Smarty"] = "smarty";
            _languageMap["SPARK"] = "spark";
            _languageMap["SPARQL"] = "sparql";
            _languageMap["SQF"] = "sqf";
            _languageMap["SQL"] = "sql";
            _languageMap["StandardML"] = "standardml";
            _languageMap["StoneScript"] = "stonescript";
            _languageMap["SuperCollider"] = "sclang";
            _languageMap["Swift"] = "swift";
            _languageMap["SystemVerilog"] = "systemverilog";
            _languageMap["T-SQL"] = "tsql";
            _languageMap["TCL"] = "tcl";
            _languageMap["Tera Term"] = "teraterm";
            _languageMap["thinBasic"] = "thinbasic";
            _languageMap["TypoScript"] = "typoscript";
            _languageMap["Unicon"] = "unicon";
            _languageMap["UnrealScript"] = "uscript";
            _languageMap["UPC"] = "upc";
            _languageMap["Urbi"] = "urbi";
            _languageMap["Vala"] = "vala";
            _languageMap["VB.NET"] = "vbnet";
            _languageMap["VBScript"] = "vbscript";
            _languageMap["Vedit"] = "vedit";
            _languageMap["VeriLog"] = "verilog";
            _languageMap["VHDL"] = "vhdl";
            _languageMap["VIM"] = "vim";
            _languageMap["Visual Pro Log"] = "visualprolog";
            _languageMap["VisualBasic"] = "vb";
            _languageMap["VisualFoxPro"] = "visualfoxpro";
            _languageMap["WhiteSpace"] = "whitespace";
            _languageMap["WHOIS"] = "whois";
            _languageMap["Winbatch"] = "winbatch";
            _languageMap["XBasic"] = "xbasic";
            _languageMap["XML"] = "xml";
            _languageMap["Xorg Config"] = "xorg_conf";
            _languageMap["XPP"] = "xpp";
            _languageMap["YAML"] = "yaml";
            _languageMap["Z80 Assembler"] = "z80";
            _languageMap["ZXBasic"] = "zxbasic";

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (_loggedIn)
            {
                var username = _settings.__userName;

                LabelLogin.Text = "Welcome, " + username;
                buttonLogin.Text = "Log Out";
                buttonLogin.Click -= buttonLogin_Click;
                buttonLogin.Click += buttonLogin_LogOut;
            }
        }

        private void textBoxContent_Clicked(object sender, EventArgs e)
        {
            using (var f = new CodeForm(textBoxContent))
            {
                f.ShowDialog();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Submit
        }

        private void buttonLogin_LogOut(object sender, EventArgs e)
        {
            _settings.__userKey = string.Empty;
            _settings.__userName = string.Empty;

            buttonLogin.Click -= buttonLogin_LogOut;
            buttonLogin.Click += buttonLogin_Click;

            buttonLogin.Text = "Log In";
            LabelLogin.Text = "Please log in to use app";


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var f = new LoginForm())
            {
                f.ShowDialog();
            }
        }
    }
}
