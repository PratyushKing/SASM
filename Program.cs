using System;
using System.IO;

namespace SASM_MAIN {

	public static class SASM {
		public static class Compiler {
			public static string CompileFVM(string[] code) {
				var output = "";
				for (var li = 0; i < code.Split('\n').Length; i++) {
					var ln = code[li];
					for (var tok = 0; tok < ln.Split(' ').Length; tok++) {
						//token declaring
						var cToken = ln.Split(' ')[tok];
						string nToken = null;
						if (ln.Split(' ').Length > tok) {
							nToken = ln.Split(' ')[tok + 1];
						}
						
						//token checking
						if (cToken.StartsWith(";")) {
							// ignore, its a comment
						}
					}
				}
				return output;
			}

			internal static class STACK {
				
			}
		}
		public static class Executor {
			public static int execute(string code) {
				return 0;
			}
		}
	}

	public static class TEST {
		private static void Main() {
			Console.WriteLine("COMPILATION START----");

			string[] code = {
				"push 10",
				"push 11",
				"pop",
				"add",
				"je",
				"sub",
				"$out::\"Hello World!\" + $get",
				"$in",
				"jne",
				"quit"
			};
			
			SASM.Compiler.compile(code);
		}
	}
}
