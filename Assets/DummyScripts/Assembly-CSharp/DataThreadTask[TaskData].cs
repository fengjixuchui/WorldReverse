/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class DataThreadTask<TaskData> : ComputeThreadTaskBase // TypeDefIndex: 21339
{
	// Fields
	protected List<TaskData>[] _dataBuffer;

	// Constructors
	public DataThreadTask() {}

	// Methods
	public List<TaskData> GetDataList(int front) => default;
}

