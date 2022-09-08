/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public interface IGroupNode : IDestroy // TypeDefIndex: 9000
	{
		// Properties
		int index { get; set; }
		int dataType { get; }
		int dataCnt { get; }
		INode node { get; }
	
		// Methods
		void Init(int maxNum, IGroup group, IGraph graph, IRunnerPool runnerPool, int groupId);
	}
}
