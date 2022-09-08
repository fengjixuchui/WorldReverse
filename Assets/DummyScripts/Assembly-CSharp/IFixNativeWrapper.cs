/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class IFixNativeWrapper // TypeDefIndex: 20735
{
	// Nested types
	public class SECURITY_ATTRIBUTES // TypeDefIndex: 20736
	{
		// Fields
		public uint nLength; // 0x10
		public string lpSecurityDescriptor; // 0x18
		public bool bInheritHandle; // 0x20

		// Constructors
		public SECURITY_ATTRIBUTES() {} // 0x00000001865855B0-0x0000000186585690
	}

	public struct PROCESS_INFORMATION // TypeDefIndex: 20737
	{
		// Fields
		public IntPtr hProcess; // 0x00
		public IntPtr hThread; // 0x08
		public int dwProcessId; // 0x10
		public int dwThreadId; // 0x14
	}

	public struct STARTUPINFO // TypeDefIndex: 20738
	{
		// Fields
		public int cb; // 0x00
		public string lpReserved; // 0x08
		public string lpDesktop; // 0x10
		public int lpTitle; // 0x18
		public int dwX; // 0x1C
		public int dwY; // 0x20
		public int dwXSize; // 0x24
		public int dwYSize; // 0x28
		public int dwXCountChars; // 0x2C
		public int dwYCountChars; // 0x30
		public int dwFillAttribute; // 0x34
		public int dwFlags; // 0x38
		public short wShowWindow; // 0x3C
		public short cbReserved2; // 0x3E
		public byte lpReserved2; // 0x40
		public IntPtr hStdInput; // 0x48
		public IntPtr hStdOutput; // 0x50
		public IntPtr hStdError; // 0x58
	}

	// Constructors
	public IFixNativeWrapper() {} // 0x000000018657A560-0x000000018657A5C0

	// Methods
	public static extern IntPtr LoadLibraryW(string lpFileName); // 0x0000000186579FB0-0x000000018657A0B0
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName); // 0x0000000186579EA0-0x0000000186579FB0
	public static extern bool FreeLibrary(IntPtr hModule); // 0x000000018657A370-0x000000018657A460
	public static extern int WaitForSingleObject(IntPtr handle, int timeout); // 0x000000018657A460-0x000000018657A560
	public static extern bool CloseHandle(IntPtr hObject); // 0x000000018657A0B0-0x000000018657A190
	private static extern bool GetExitCodeProcess(IntPtr hProcess, ref uint lpExitCode); // 0x0000000186579DA0-0x0000000186579EA0
	public static extern bool CreateProcess(StringBuilder lpApplicationName, StringBuilder lpCommandLine, SECURITY_ATTRIBUTES lpProcessAttributes, SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, StringBuilder lpEnvironment, StringBuilder lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation); // 0x0000000186579990-0x0000000186579DA0
	public static extern bool TerminateProcess(IntPtr processHandle, int exitCode); // 0x000000018657A190-0x000000018657A290
	public static extern uint GetCurrentProcessId(); // 0x000000018657A290-0x000000018657A370
}

