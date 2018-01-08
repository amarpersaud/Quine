using System;
public class Program
{
    public static string s =
    @"		using System;
		public class Program
		{{
			public static string s = 
			@""{0}"";
			public static void Main(){{
				string b = (""    "" + s.Replace(""\n"", ""\n"" + ""    "")).Replace(""\"""", ""\""\"""");
				Console.WriteLine(String.Format(s, b));
			}}
		}}";
    public static void Main()
    {
        string b = ("    " + s.Replace("\n", "\n" + "    ")).Replace("\"", "\"\"");
        Console.WriteLine(String.Format(s.Replace("        ", "    "), b));
    }
}