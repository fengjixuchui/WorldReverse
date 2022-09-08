/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public sealed class DelegateBridge : DelegateBridgeBase // TypeDefIndex: 32214
	{
		// Fields
		internal static DelegateBridge[] DelegateBridgeList; // 0x00
		public static bool Gen_Flag; // 0x08
		private int _oldTop; // 0x40
		private Stack<int> _stack; // 0x48
	
		// Constructors
		public DelegateBridge() {} // Dummy constructor
		static DelegateBridge() {} // 0x0000000183EEA9E0-0x0000000183EEAA80
		public DelegateBridge(int reference, LuaEnv luaenv) {} // 0x0000000183EEAA80-0x0000000183EEABC0
	
		// Methods
		public void __Gen_Delegate_Imp0(ILuaActor p0, object p1) {} // 0x0000000183EE7A00-0x0000000183EE7BD0
		public void __Gen_Delegate_Imp1(ILuaActor p0, object p1, object p2) {} // 0x0000000183EE8E20-0x0000000183EE9000
		public void __Gen_Delegate_Imp2(ILuaActor p0, object p1, object p2, object p3) {} // 0x0000000183EE9C70-0x0000000183EE9E70
		public void __Gen_Delegate_Imp3() {} // 0x0000000183EE9E70-0x0000000183EE9FF0
		public void __Gen_Delegate_Imp4(string p0) {} // 0x0000000183EE9FF0-0x0000000183EEA190
		public void __Gen_Delegate_Imp5(double p0) {} // 0x0000000183EEA190-0x0000000183EEA330
		public void __Gen_Delegate_Imp6(int p0) {} // 0x0000000183EEA330-0x0000000183EEA4D0
		public void __Gen_Delegate_Imp7(uint p0, uint p1) {} // 0x0000000183EEA4D0-0x0000000183EEA680
		public void __Gen_Delegate_Imp8(LuaTask p0) {} // 0x0000000183EEA680-0x0000000183EEA830
		public void __Gen_Delegate_Imp9(QuestProxy p0) {} // 0x0000000183EEA830-0x0000000183EEA9E0
		public void __Gen_Delegate_Imp10(ILuaActor p0, QuestProxy p1) {} // 0x0000000183EE7BD0-0x0000000183EE7DA0
		public void __Gen_Delegate_Imp11(ILuaActor p0) {} // 0x0000000183EE7DA0-0x0000000183EE7F50
		public void __Gen_Delegate_Imp12(ILuaActor p0, ILuaActorCollisionInfo p1) {} // 0x0000000183EE7F50-0x0000000183EE8120
		public void __Gen_Delegate_Imp13(ILuaActor p0, int p1) {} // 0x0000000183EE8120-0x0000000183EE82F0
		public void __Gen_Delegate_Imp14(ILuaActor p0, ActorEvent p1) {} // 0x0000000183EE82F0-0x0000000183EE84C0
		public void __Gen_Delegate_Imp15(ILuaActor p0, LuaTask p1) {} // 0x0000000183EE84C0-0x0000000183EE8690
		public void __Gen_Delegate_Imp16(ILuaActor p0, object[] p1) {} // 0x0000000183EE8690-0x0000000183EE8860
		public void __Gen_Delegate_Imp17(ILuaActor p0, LuaTask p1, float p2) {} // 0x0000000183EE8860-0x0000000183EE8A60
		public void __Gen_Delegate_Imp18(ILuaActor p0, uint p1, string p2) {} // 0x0000000183EE8A60-0x0000000183EE8C40
		public void __Gen_Delegate_Imp19(ILuaActor p0, ILuaActor p1, int p2) {} // 0x0000000183EE8C40-0x0000000183EE8E20
		public bool __Gen_Delegate_Imp20(ILuaActor p0, QuestProxy p1) => default; // 0x0000000183EE9000-0x0000000183EE9200
		public void __Gen_Delegate_Imp21(ILuaActor p0, List<ActorSensibleInfo> p1) {} // 0x0000000183EE9200-0x0000000183EE93D0
		public void __Gen_Delegate_Imp22(ILuaActor p0, LuaTask p1, LuaThreatInfo p2) {} // 0x0000000183EE93D0-0x0000000183EE95B0
		public void __Gen_Delegate_Imp23(GameObject p0) {} // 0x0000000183EE95B0-0x0000000183EE9760
		public void __Gen_Delegate_Imp24(List<GameObject> p0) {} // 0x0000000183EE9760-0x0000000183EE9910
		public void __Gen_Delegate_Imp25(BaseEntity p0) {} // 0x0000000183EE9910-0x0000000183EE9AC0
		public void __Gen_Delegate_Imp26(List<BaseEntity> p0) {} // 0x0000000183EE9AC0-0x0000000183EE9C70
		public override Delegate GetDelegateByType(System.Type type) => default; // 0x0000000183EE67F0-0x0000000183EE7580
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc) {} // 0x0000000183EE7940-0x0000000183EE7A00
		public void InvokeSessionStart() {} // 0x0000000183EE7680-0x0000000183EE77C0
		public void Invoke(int nRet) {} // 0x0000000183EE77C0-0x0000000183EE7940
		public void InvokeSessionEnd() {} // 0x0000000183EE7580-0x0000000183EE7680
		public TResult InvokeSessionEndWithResult<TResult>() => default;
		public void InParam<T>(T p) {}
		public void InParams<T>(T[] ps) {}
		public void OutParam<TResult>(int pos, out TResult ret) {
			ret = default;
		}
		public void Action() {} // 0x0000000183EE6610-0x0000000183EE67F0
		public void Action<T1>(T1 p1) {}
		public void Action<T1, T2>(T1 p1, T2 p2) {}
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3) {}
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) {}
		public TResult Func<TResult>() => default;
		public TResult Func<T1, TResult>(T1 p1) => default;
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2) => default;
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3) => default;
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4) => default;
	}
}
