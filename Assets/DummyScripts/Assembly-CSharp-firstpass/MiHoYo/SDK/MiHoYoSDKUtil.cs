/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKUtil // TypeDefIndex: 8917
	{
		// Fields
		private static byte[] Keys; // 0x00
	
		// Constructors
		public MiHoYoSDKUtil() {} // 0x0000000185972DD0-0x0000000185972E30
		static MiHoYoSDKUtil() {} // 0x0000000185972D30-0x0000000185972DD0
	
		// Methods
		// [XID] // 0x0000000189662F20-0x0000000189662F40
		public static string SHA1(string message) => default; // 0x0000000185971C20-0x0000000185971D70
		// [XID] // 0x0000000189613D90-0x0000000189613DB0
		public static string HMACSHA1(string message, string secret) => default; // 0x0000000185971220-0x00000001859714C0
		// [XID] // 0x0000000189A33F80-0x0000000189A33FA0
		public static string HMACSHA256(string message, string secret) => default; // 0x00000001859714C0-0x0000000185971760
		// [XID] // 0x000000018967A020-0x000000018967A040
		public static string RSAEncrypt(string publickey, string content) => default; // 0x0000000185971AA0-0x0000000185971C20
		// [XID] // 0x00000001898FCD80-0x00000001898FCDA0
		public static string RSADecrypt(string key, string content) => default; // 0x0000000185971930-0x0000000185971AA0
		// [XID] // 0x0000000189689140-0x0000000189689160
		public static byte[] StringToBytes(string str) => default; // 0x0000000185972AC0-0x0000000185972C50
		// [XID] // 0x0000000189690CC0-0x0000000189690CE0
		public static string SpecialCode(string s) => default; // 0x0000000185972850-0x0000000185972970
		// [XID] // 0x00000001896985D0-0x00000001896985F0
		public static string SignMdkBody(JSONObject content, string secret) => default; // 0x0000000185972470-0x0000000185972850
		// [XID] // 0x0000000189A25310-0x0000000189A25330
		public static string SignComboBody(JSONObject content, string secret) => default; // 0x0000000185971EC0-0x0000000185972470
		// [XID] // 0x0000000189AA3080-0x0000000189AA30A0
		public static Color GetColor(string colorString) => default; // 0x0000000185970300-0x0000000185970420
		// [XID] // 0x00000001896AE1F0-0x00000001896AE210
		public static string GetQueryString(JSONObject query) => default; // 0x00000001859708F0-0x0000000185970E50
		// [XID] // 0x00000001896B5920-0x00000001896B5940
		public static JSONObject GetQuery(string queryString) => default; // 0x0000000185970E50-0x00000001859710F0
		// [XID] // 0x00000001898BC150-0x00000001898BC170
		public static string UnEscapeURL(string url) => default; // 0x0000000185972C50-0x0000000185972D30
		// [XID] // 0x00000001898BE0C0-0x00000001898BE0E0
		public static string StringToBase64(string inputString) => default; // 0x0000000185972970-0x0000000185972AC0
		// [XID] // 0x000000018961B760-0x000000018961B780
		public static string Md5Sum(string input) => default; // 0x0000000185971760-0x0000000185971930
		// [XID] // 0x00000001896D2B30-0x00000001896D2B50
		public static string GetContentMD5(string input) => default; // 0x0000000185970420-0x00000001859705A0
		// [XID] // 0x00000001896DA530-0x00000001896DA550
		public static string EncodeString(string encryptString, string encodeValue = null) => default; // 0x0000000185970030-0x0000000185970300
		// [XID] // 0x000000018987A770-0x000000018987A790
		public static string DecodeString(string decryptString, string encodeValue = null) => default; // 0x000000018596FD60-0x0000000185970030
		// [XID] // 0x0000000189888F00-0x0000000189888F20
		private static string GetEncodeValue(string encodeStrnig) => default; // 0x00000001859705A0-0x00000001859706E0
		// [XID] // 0x00000001896F03A0-0x00000001896F03C0
		public static string GetMacAddress() => default; // 0x00000001859706E0-0x00000001859708F0
		// [XID] // 0x00000001896F7D70-0x00000001896F7D90
		public static void SetSaveString(string key, string value, bool isEncode = false /* Metadata: 0x00AE4E42 */) {} // 0x0000000185971D70-0x0000000185971EC0
		// [XID] // 0x00000001896FF710-0x00000001896FF730
		public static string GetSaveString(string key, bool isDecode = false /* Metadata: 0x00AE4E43 */) => default; // 0x00000001859710F0-0x0000000185971220
		// [XID] // 0x00000001896D20A0-0x00000001896D20C0
		public static string AesEncrypt(string str, string key) => default; // 0x000000018596FAE0-0x000000018596FD60
		// [XID] // 0x000000018970E450-0x000000018970E470
		public static string AesDecrypt(string str, string key) => default; // 0x000000018596F870-0x000000018596FAE0
	}
}
