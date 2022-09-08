/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using RootMotion;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.FinalIK
{
	public abstract class IK : SolverManager // TypeDefIndex: 9838
	{
		// Constructors
		protected IK() {} // 0x00000001868D3290-0x00000001868D3340
	
		// Methods
		public abstract IKSolver GetIKSolver();
		// [XID] // 0x0000000189658920-0x0000000189658940
		protected override void UpdateSolver() {} // 0x00000001868D30E0-0x00000001868D3290
		// [XID] // 0x000000018965FF70-0x000000018965FF90
		protected override void InitiateSolver() {} // 0x00000001868D2E80-0x00000001868D2FC0
		// [XID] // 0x00000001896DF820-0x00000001896DF840
		protected override void FixTransforms() {} // 0x00000001868D2D40-0x00000001868D2E80
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
