/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public interface IGroup : IDestroy // TypeDefIndex: 9001
	{
		// Properties
		int groupId { get; }
	
		// Methods
		List<INode> GetNodes();
		void Precede(INode node);
		void Precede(IGroup group);
		IGroupNode GetValidNode();
		IGroupNode GetNodeByIndex(int index);
		void SwitchRunnerPool(IRunnerPool runnerPool);
		bool Balence();
	}
}
