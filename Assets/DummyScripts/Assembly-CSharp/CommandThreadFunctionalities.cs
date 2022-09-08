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

public abstract class CommandThreadFunctionalities // TypeDefIndex: 11263
{
	// Fields
	private readonly CommandThreadContext _context; // 0x10

	// Properties
	protected CommandThreadContext context { /* [XID] */ /* 0x000000018988AF50-0x000000018988AF70 */ get; } // 0x0000000183367790-0x0000000183367830 

	// Constructors
	protected CommandThreadFunctionalities() {} // Dummy constructor
	public CommandThreadFunctionalities(CommandThreadContext context) {} // 0x0000000183367830-0x00000001833678A0

	// Methods
	public abstract void Init();
	public abstract void Tick(float deltaTime);
	public abstract void EnterHomeWorld(bool firstTime);
	public abstract void ExitHomeWorld();
	public abstract void ExitGameWorld();
	public abstract void CreateLevel();
	public abstract void EnterLevel();
	public abstract void ExitLevel();
	public abstract void DumpCriticalInfo(StringBuilder builder);
	public abstract void Destroy();
}

