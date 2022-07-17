/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: MihoyoOptimization.dll - Assembly: MihoyoOptimization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6668-6675

namespace MihoyoOptimization
{
	public class RecycleType : Attribute // TypeDefIndex: 6674
	{
		// Fields
		public ERecycleCodeGen _codeGenStyle; // 0x10
		public ERecycleThread _recycleThread; // 0x14
	
		// Constructors
		public RecycleType(ERecycleCodeGen inCodeGenStyle = ERecycleCodeGen.Mean /* Metadata: 0x00ADD9C8 */, ERecycleThread inRecycleThread = ERecycleThread.DefaultMain /* Metadata: 0x00ADD9CC */) 
		{
			_codeGenStyle = inCodeGenStyle;
			_recycleThread = inRecycleThread;
		} // 0x00000001895B4620-0x00000001895B46A0
	}
}
