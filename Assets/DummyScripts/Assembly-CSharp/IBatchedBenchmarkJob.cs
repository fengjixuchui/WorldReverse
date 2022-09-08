/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IBatchedBenchmarkJob // TypeDefIndex: 27566
{
	// Properties
	string statFolderName { get; }
	string statFileType { get; }
	string statFileName { get; }
	int statLOD { get; }

	// Methods
	string ToCSVTitleString();
	string ToValidStatCSVString(StatUnitMMA inStat);
	string ToInvalidStatCSVString();
	void PreStat();
	int GetJobCount();
	IEnumerator ExecuteAt(int index);
	void PostStat();
}

