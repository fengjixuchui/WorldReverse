/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IThreadListener // TypeDefIndex: 21337
{
	// Properties
	bool Alive { get; }

	// Methods
	void Init(IThreadTask task);
	IThreadTask GetTask();
	void RenderTick(int renderFront, float renderTime);
	void Destroy(bool includeTask);
}

