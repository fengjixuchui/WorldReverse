/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioDelayedWorker<T> : IAudioDelayedWorker // TypeDefIndex: 10942
	where T : IAudioUiTickable
{
	// Properties
	public T host { get; set; }
	public IAudioUiTickable tickableHost { get; }

	// Constructors
	protected AudioDelayedWorker() {}

	// Methods
	public abstract void DoWork();
	public abstract void Recycle();
	public virtual void BeforeRecycle() {}
}

