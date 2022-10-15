namespace Raylib 
{
	public static class Convert 
	{
		public static string ToString(object obj) { return obj.ToString(); }

		public static float itof(int num) { return float.Parse(num.ToString()); }
		public static int ftoi(float num) { return int.Parse(num.ToString()); }
		public static float stof(string num) { return float.Parse(num); }
		public static string ftos(float num) { return num.ToString(); }
		public static int stoi(string num) { return int.Parse(num); }
		public static string itos(int num) { return num.ToString(); }

		public static int HexToDecimal(string hex) 
		{
			if (string.IsNullOrEmpty(hex)) { throw new System.ArgumentException("String must not be null or empty."); }

			int output = 0;
			char[] hexBy1 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
			for (int i = 0; i < hex.Length; i++) 
			{
				if (hex[i] == '0' && output == 0) { continue; }
				output += System.Array.IndexOf(hexBy1, hex[i]);
				output = output << 4;
			}

			return output >> 4;
		}

		public static string DecimalToHex(int dec) 
		{
			string output = "";
			string[] hexBy1 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
			while (dec != 0 || output == "") 
			{
				output = hexBy1[dec & 0xf] + output;
				dec = dec >> 4;
			}

			return output;
		}

		public static int BinaryToDecimal(string bin) 
		{
			if (string.IsNullOrEmpty(bin)) { throw new System.ArgumentException("String must not be null or empty."); }

			int output = 0;
			for (int i = 0; i < bin.Length; i++) 
			{
				if (bin[i] == '0' && output == 0) { continue; }
				output += bin[i] == '1' ? 1 : 0;
				output = output << 1;
			}

			return output >> 1;
		}

		public static string DecimalToBinary(int dec) 
		{
			string output = "";
			while (dec != 0 || output == "") 
			{
				output = ((dec & 1) == 1 ? "1" : "0") + output;
				dec = dec >> 1;
			}

			return output;
		}
	}
}