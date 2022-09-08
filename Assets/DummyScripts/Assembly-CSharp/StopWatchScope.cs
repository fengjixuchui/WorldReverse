/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StopWatchScope : IDisposable // TypeDefIndex: 31981
{
	// Fields
	private const string RESULT_DESC = "\u8BA1\u65F6"; // Metadata: 0x00B13A81
	private const string MS = "ms"; // Metadata: 0x00B13A97
	private readonly StringBuilder _stringBuilder; // 0x10
	private readonly Stopwatch _stopwatch; // 0x18
	private readonly string _desc; // 0x20

	// Constructors
	public StopWatchScope() {} // Dummy constructor
	public StopWatchScope(string desc = "" /* Metadata: 0x00B13A7D */) {} // 0x00000001832667F0-0x0000000183266910

	// Methods
	// [XID] // 0x00000001898034A0-0x00000001898034C0
	public long GetElapsedMilliseconds() => default; // 0x0000000183266740-0x00000001832667F0
	// [XID] // 0x000000018980AA40-0x000000018980AA60
	public void Dispose() {} // 0x0000000183266550-0x0000000183266740
}

