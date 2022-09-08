/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class Submodule // TypeDefIndex: 11423
{
	// Constructors
	protected Submodule() {} // 0x00000001831956A0-0x0000000183195700

	// Methods
	public abstract void CommandInit();
	public abstract void CommandTick(float deltaTime);
	public abstract void CommandEnterHomeWorld(bool firstTime);
	public abstract void CommandExitHomeWorld();
	public abstract void CommandExitGameWorld();
	public abstract void CommandCreateLevel();
	public abstract void CommandEnterLevel();
	public abstract void CommandExitLevel();
	public abstract void CommandDestroy();
}

