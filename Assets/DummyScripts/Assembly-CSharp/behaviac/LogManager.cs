/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class LogManager : IDisposable // TypeDefIndex: 27212
	{
		// Fields
		private static LogManager ms_instance; // 0x00
	
		// Properties
		public static LogManager Instance { get => default; } // 0x0000000186DEBF40-0x0000000186DEC010 
	
		// Constructors
		public LogManager() {} // 0x0000000186DEBEA0-0x0000000186DEBF40
		static LogManager() {} // 0x0000000186DEBE40-0x0000000186DEBEA0
	
		// Methods
		public void Dispose() {} // 0x0000000186DEB8B0-0x0000000186DEB940
		public void SetLogFilePath(string logFilePath) {} // 0x0000000186DEBD50-0x0000000186DEBDA0
		public void Log(Agent pAgent, string btMsg, EActionResult actionResult, LogMode mode) {} // 0x0000000186DEBC60-0x0000000186DEBCB0
		public void PLanningClearCache() {} // 0x0000000186DEBD00-0x0000000186DEBD50
		public void Log(Agent pAgent, string typeName, string varName, string value) {} // 0x0000000186DEBBC0-0x0000000186DEBC10
		public void Log(Agent pAgent, string btMsg, long time) {} // 0x0000000186DEBB20-0x0000000186DEBB70
		public void Log(LogMode mode, string filterString, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x0000000186DEBC10-0x0000000186DEBC60
		public void Log(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x0000000186DEBB70-0x0000000186DEBBC0
		public void LogWorkspace(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x0000000186DEBAD0-0x0000000186DEBB20
		public void LogVarValue(Agent pAgent, string name, object value) {} // 0x0000000186DEBA80-0x0000000186DEBAD0
		public void Warning(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x0000000186DEBDA0-0x0000000186DEBE40
		public void Error(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x0000000186DEB940-0x0000000186DEB9E0
		public void Flush(Agent pAgent) {} // 0x0000000186DEB9E0-0x0000000186DEBA30
		public void Close() {} // 0x0000000186DEB860-0x0000000186DEB8B0
		protected virtual StreamWriter GetFile(Agent pAgent) => default; // 0x0000000186DEBA30-0x0000000186DEBA80
		private void Output(Agent pAgent, string msg) {} // 0x0000000186DEBCB0-0x0000000186DEBD00
	}
}
