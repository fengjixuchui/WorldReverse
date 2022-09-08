/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class FileDownloadTask // TypeDefIndex: 8652
	{
		// Fields
		public string md5; // 0x10
		public string url; // 0x18
		public string path; // 0x20
		public string ETag; // 0x28
		public string filename; // 0x30
		private FileStream fileStream; // 0x38
		private int RetryCount; // 0x40
		private static int Timeout; // 0x00
		private static int ReadWriteTimeout; // 0x04
		private bool _pause; // 0x44
		private int _contentLength; // 0x48
		public string exceptionPayload; // 0x50
		public FileDownloadErrorCode errorCode; // 0x58
		public int errorCodeIntValue; // 0x5C
		public string errorTextMessage; // 0x60
		public Exception exception; // 0x68
		[XmlIgnore] // 0x0000000189A32AD0-0x0000000189A32AE0
		public bool CancelDownload; // 0x70
		[XmlIgnore] // 0x0000000189A32AD0-0x0000000189A32AE0
		public FileDownloadStatus status; // 0x74
	
		// Properties
		private string tmpPath { /* [XID] */ /* 0x00000001898F2640-0x00000001898F2660 */ get => default; } // 0x00000001859E0A50-0x00000001859E0B30 
		private string md5tmpPath { /* [XID] */ /* 0x0000000189AAC2D0-0x0000000189AAC2F0 */ get => default; } // 0x00000001859E0970-0x00000001859E0A50 
		private bool Paused { /* [XID] */ /* 0x00000001898F9D80-0x00000001898F9DA0 */ get => default; } // 0x00000001859E0170-0x00000001859E0250 
		public int ContentLength { /* [XID] */ /* 0x0000000189ABB870-0x0000000189ABB890 */ get => default; } // 0x00000001859DFF90-0x00000001859E0030 
		public int BytesWritten { /* [XID] */ /* 0x0000000189AC2FF0-0x0000000189AC3030 */ get; /* [XID] */ /* 0x0000000189ACD960-0x0000000189ACD9A0 */ private set; } // 0x00000001859DFF30-0x00000001859DFF90 0x00000001859E0B30-0x00000001859E0B90
		public bool Done { /* [XID] */ /* 0x0000000189AD8440-0x0000000189AD8460 */ get => default; } // 0x00000001859E0030-0x00000001859E0170 
		public string errorMessage { /* [XID] */ /* 0x0000000189AE00E0-0x0000000189AE0100 */ get => default; } // 0x00000001859E0250-0x00000001859E03A0 
		public JSONObject jsonNode { /* [XID] */ /* 0x0000000189AC96E0-0x0000000189AC9700 */ get => default; } // 0x00000001859E03A0-0x00000001859E0890 
		public string jsonString { /* [XID] */ /* 0x0000000189AE7E30-0x0000000189AE7E50 */ get => default; } // 0x00000001859E0890-0x00000001859E0970 
	
		// Nested types
		public delegate void OnProgressChange(FileDownloadTask task, float progress); // TypeDefIndex: 8653; 0x00000001859F2DE0-0x00000001859F3080
	
		// Constructors
		public FileDownloadTask() {} // 0x00000001859DFE80-0x00000001859DFF30
		public FileDownloadTask(JSONObject jsonObject) {} // 0x00000001859DFB60-0x00000001859DFE80
		static FileDownloadTask() {} // 0x00000001859DFAE0-0x00000001859DFB60
	
		// Methods
		// [XID] // 0x0000000189AE7730-0x0000000189AE7750
		public void Start() {} // 0x00000001859DDC50-0x00000001859DDD00
		// [XID] // 0x0000000189B8E100-0x0000000189B8E120
		private void _Resume() {} // 0x00000001859DE930-0x00000001859DF490
		// [XID] // 0x0000000189AA3CA0-0x0000000189AA3CC0
		public bool Pause() => default; // 0x00000001859DDBA0-0x00000001859DDC50
		// [XID] // 0x0000000189B05F20-0x0000000189B05F40
		public void Cancel() {} // 0x00000001859DD890-0x00000001859DD9E0
		// [XID] // 0x0000000189AB9840-0x0000000189AB9860
		private bool _CreateDirectoryIfNeeded() => default; // 0x00000001859DE160-0x00000001859DE280
		// [XID] // 0x0000000189B0CC60-0x0000000189B0CC80
		private bool _CheckLocalFile() => default; // 0x00000001859DDD00-0x00000001859DE160
		// [XID] // 0x0000000189B141F0-0x0000000189B14210
		private bool _RequestFileHeader() => default; // 0x00000001859DE390-0x00000001859DE930
		// [XID] // 0x000000018971AD00-0x000000018971AD20
		private void _RetryIfNeeded(Exception exception, FileDownloadErrorCode code) {} // 0x00000001859DF490-0x00000001859DF980
		// [XID] // 0x0000000189B22FD0-0x0000000189B22FF0
		private bool _SaveMD5FileIfNeeded() => default; // 0x00000001859DF980-0x00000001859DFAE0
		// [XID] // 0x0000000189B8BA20-0x0000000189B8BA40
		private void _DeleteMD5FileIfNeeded() {} // 0x00000001859DE280-0x00000001859DE390
		// [XID] // 0x000000018994C2C0-0x000000018994C2E0
		private static bool AcceptRangesForResponse(WebResponse response) => default; // 0x00000001859DD730-0x00000001859DD890
		// [XID] // 0x0000000189AF7060-0x0000000189AF7080
		private static string ETagForResponse(WebResponse response) => default; // 0x00000001859DD9E0-0x00000001859DDAF0
		// [XID] // 0x0000000189A85E50-0x0000000189A85E70
		public string JSONString() => default; // 0x00000001859DDAF0-0x00000001859DDBA0
	}
}
