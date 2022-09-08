/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class LuaBaseManager : GlobalManager // TypeDefIndex: 21115
	{
		// Fields
		protected LuaEnv _luaenv; // 0x10
	
		// Properties
		public LuaEnv LuaEnv { /* [XID] */ /* 0x00000001899A6CD0-0x00000001899A6CF0 */ get => default; } // 0x0000000183A46310-0x0000000183A463B0 
	
		// Constructors
		public LuaBaseManager() {} // 0x0000000183A462B0-0x0000000183A46310
	
		// Methods
		// [XID] // 0x00000001896CF1E0-0x00000001896CF200
		public override void Init() {} // 0x0000000183A43F20-0x0000000183A43FC0
		// [XID] // 0x0000000189985350-0x0000000189985370
		protected virtual void InitLua() {} // 0x0000000183A43E60-0x0000000183A43F20
		// [XID] // 0x0000000189976490-0x00000001899764B0
		public void DoLua(string filePath, string fileName = "chunk" /* Metadata: 0x00AFEE6F */) {} // 0x0000000183A42940-0x0000000183A42AE0
		// [XID] // 0x00000001896E5210-0x00000001896E5230
		public virtual void Require(string scriptPath) {} // 0x0000000183A45340-0x0000000183A453F0
		// [XID] // 0x000000018969F9F0-0x000000018969FA10
		protected virtual void OnLoadLuaFinish() {} // 0x0000000183A45200-0x0000000183A452A0
		// [XID] // 0x00000001896F3F00-0x00000001896F3F20
		public override void ReloadRes() {} // 0x0000000183A452A0-0x0000000183A45340
		// [XID] // 0x00000001896FB750-0x00000001896FB770
		public override void Tick() {} // 0x0000000183A45760-0x0000000183A458A0
		// [XID] // 0x0000000189702DB0-0x0000000189702DD0
		public override void Destroy() {} // 0x0000000183A42890-0x0000000183A42940
		// [XID] // 0x000000018970A460-0x000000018970A480
		public override void ClearOnLevelDestroy() {} // 0x0000000183A3E990-0x0000000183A3EA30
		// [XID] // 0x0000000189711F70-0x0000000189711F90
		public void WaitForSeconds(float seconds, LuaFunction luaCallback, LuaTable args = null) {} // 0x0000000183A45EB0-0x0000000183A46030
		[DebuggerHidden] // 0x0000000189719510-0x0000000189719550
		// [XID] // 0x0000000189719510-0x0000000189719550
		private IEnumerator WaitForSecondsImp(float seconds, LuaFunction luaCallback, LuaTable args = null) => default; // 0x0000000183A45DA0-0x0000000183A45EB0
		// [XID] // 0x00000001897237F0-0x0000000189723810
		public void WaitForSeveralFrames(int delayFrameCount, LuaFunction luaCallback, LuaTable args = null) {} // 0x0000000183A46130-0x0000000183A462B0
		[DebuggerHidden] // 0x000000018972AF70-0x000000018972AFB0
		// [XID] // 0x000000018972AF70-0x000000018972AFB0
		private IEnumerator WaitForSeveralFramesImp(int delayFrameCount, LuaFunction luaCallback, LuaTable args = null) => default; // 0x0000000183A46030-0x0000000183A46130
		// [XID] // 0x00000001897355D0-0x00000001897355F0
		public void WaitForEndOfFrame(LuaFunction luaCallback, LuaTable args = null) {} // 0x0000000183A459F0-0x0000000183A45B50
		[DebuggerHidden] // 0x000000018973D190-0x000000018973D1D0
		// [XID] // 0x000000018973D190-0x000000018973D1D0
		private IEnumerator WaitForEndOfFrameImp(LuaFunction luaCallback, LuaTable args = null) => default; // 0x0000000183A45900-0x0000000183A459F0
		// [XID] // 0x0000000189747930-0x0000000189747950
		public void WaitForFixedUpdate(LuaFunction luaCallback, LuaTable args = null) {} // 0x0000000183A45C40-0x0000000183A45DA0
		[DebuggerHidden] // 0x000000018974F0B0-0x000000018974F0F0
		// [XID] // 0x000000018974F0B0-0x000000018974F0F0
		private IEnumerator WaitForFixedUpdateImp(LuaFunction luaCallback, LuaTable args = null) => default; // 0x0000000183A45B50-0x0000000183A45C40
		// [XID] // 0x00000001897593E0-0x0000000189759400
		public bool IsIOS() => default; // 0x0000000183A44D40-0x0000000183A44DE0
		// [XID] // 0x0000000189760FB0-0x0000000189760FD0
		public bool IsAndroid() => default; // 0x0000000183A44CA0-0x0000000183A44D40
		// [XID] // 0x0000000189768340-0x0000000189768360
		public void ModifySafeFloat(object inputObject, string propertyName, float propertyVal) {} // 0x0000000183A44F40-0x0000000183A450A0
		// [XID] // 0x000000018976F9F0-0x000000018976FA10
		public void ModifySafeInt(object inputObject, string propertyName, int propertyVal) {} // 0x0000000183A450A0-0x0000000183A45200
		// [XID] // 0x0000000189777250-0x0000000189777270
		public void ModifySafeBool(object inputObject, string propertyName, bool propertyVal) {} // 0x0000000183A44DE0-0x0000000183A44F40
		// [XID] // 0x000000018977E9A0-0x000000018977E9C0
		public ActorAbilityPlugin GetActorPlugin(uint runtimeID, string pluginTypeName) => default; // 0x0000000183A42AE0-0x0000000183A42C40
		// [XID] // 0x0000000189786120-0x0000000189786140
		public object GetNetPacketV1Data(Packet packet, string dataClassName) => default; // 0x0000000183A42E30-0x0000000183A42F60
		// [XID] // 0x000000018978D790-0x000000018978D7B0
		public LuaTable CreateLuaTable() => default; // 0x0000000183A41890-0x0000000183A419A0
		// [XID] // 0x0000000189794C60-0x0000000189794C80
		public LuaTable ConvertDictionaryToLuaTable(IDictionary objs) => default; // 0x0000000183A3EC30-0x0000000183A3EEA0
		// [XID] // 0x000000018979D1D0-0x000000018979D1F0
		public ArrayList ConvertDictionaryKeysToList(IDictionary objs) => default; // 0x0000000183A3EA30-0x0000000183A3EC30
		// [XID] // 0x00000001897A4490-0x00000001897A44B0
		public Delegate CreateLuaDelegate(string delegateTypeAssemblyQualifiedName, LuaFunction luaFunc) => default; // 0x0000000183A41690-0x0000000183A41890
		// [XID] // 0x00000001897ABA00-0x00000001897ABA20
		public Delegate CreateLuaAction(bool useUnityAction, LuaFunction luaFunc) => default; // 0x0000000183A41500-0x0000000183A41690
		// [XID] // 0x00000001897B3940-0x00000001897B3960
		public Delegate CreateLuaActionWithOneArg(bool useUnityAction, LuaFunction luaFunc, string argAssemblyName, string argClassName) => default; // 0x0000000183A40D60-0x0000000183A40FC0
		// [XID] // 0x00000001897BB750-0x00000001897BB770
		public Delegate CreateLuaActionWithTwoArgs(bool useUnityAction, LuaFunction luaFunc, string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName) => default; // 0x0000000183A41280-0x0000000183A41500
		// [XID] // 0x00000001897C2FB0-0x00000001897C2FD0
		public Delegate CreateLuaActionWithThreeArgs(bool useUnityAction, LuaFunction luaFunc, string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName, string arg3AssemblyName, string arg3ClassName) => default; // 0x0000000183A40FC0-0x0000000183A41280
		// [XID] // 0x00000001897CA850-0x00000001897CA870
		public Delegate CreateLuaActionWithFourArgs(bool useUnityAction, LuaFunction luaFunc, string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName, string arg3AssemblyName, string arg3ClassName, string arg4AssemblyName, string arg4ClassName) => default; // 0x0000000183A40A60-0x0000000183A40D60
		// [XID] // 0x00000001897D1E10-0x00000001897D1E30
		public Delegate CreateDelegate(string delegateTypeAssemblyQualifiedName, object obj, string methodName, bool isStatic) => default; // 0x0000000183A3FEA0-0x0000000183A400C0
		// [XID] // 0x00000001897D9C70-0x00000001897D9C90
		public Delegate CreateAction(bool useUnityAction, object obj, string methodName, bool isStatic) => default; // 0x0000000183A3FD00-0x0000000183A3FEA0
		// [XID] // 0x00000001897E0FA0-0x00000001897E0FC0
		public Delegate CreateActionWithOneArg(bool useUnityAction, object obj, string methodName, bool isStatic, string argAssemblyName, string argClassName) => default; // 0x0000000183A3F840-0x0000000183A3FA80
		// [XID] // 0x00000001897E8690-0x00000001897E86B0
		public Delegate CreateActionWithTwoArgs(bool useUnityAction, object obj, string methodName, bool isStatic, string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName) => default; // 0x0000000183A3FA80-0x0000000183A3FD00
		// [XID] // 0x00000001897F0360-0x00000001897F0380
		public Delegate CreateActionWithMultiArgs(bool useUnityAction, object obj, string methodName, bool isStatic, LuaTable argTable) => default; // 0x0000000183A3F400-0x0000000183A3F840
		// [XID] // 0x00000001897F7AD0-0x00000001897F7AF0
		public Delegate CreateStaticClassDelegate(string delegateTypeAssemblyQualifiedName, string classAssemblyQualifiedName, string methodName) => default; // 0x0000000183A425A0-0x0000000183A42890
		// [XID] // 0x00000001897FF150-0x00000001897FF170
		public Delegate CreateStaticClassAction(bool useUnityAction, string assemblyName, string className, string methodName) => default; // 0x0000000183A42380-0x0000000183A425A0
		// [XID] // 0x0000000189806890-0x00000001898068B0
		public Delegate CreateStaticClassActionWithOneArg(bool useUnityAction, string assemblyName, string className, string methodName, string argAssemblyName, string argClassName) => default; // 0x0000000183A41DC0-0x0000000183A42080
		// [XID] // 0x000000018980E070-0x000000018980E090
		public Delegate CreateStaticClassActionWithTwoArgs(bool useUnityAction, string assemblyName, string className, string methodName, string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName) => default; // 0x0000000183A42080-0x0000000183A42380
		// [XID] // 0x0000000189815750-0x0000000189815770
		public Delegate CreateStaticClassActionWithMultiArgs(bool useUnityAction, string assemblyName, string className, string methodName, LuaTable argTable) => default; // 0x0000000183A419A0-0x0000000183A41DC0
		// [XID] // 0x000000018981D140-0x000000018981D160
		public object CreateInstance(string assemblyName, string className, bool nonPublic) => default; // 0x0000000183A408F0-0x0000000183A40A60
		// [XID] // 0x00000001898245A0-0x00000001898245C0
		public object CreateGenericInstance(string assemblyName, string className, string argAssemblyName, string argClassName) => default; // 0x0000000183A406D0-0x0000000183A408F0
		// [XID] // 0x000000018982C070-0x000000018982C090
		public object CreateGenericInstanceWithTwoArgs(string assemblyName, string className, string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName) => default; // 0x0000000183A40410-0x0000000183A406D0
		// [XID] // 0x0000000189833540-0x0000000189833560
		public object CreateGenericInstanceWithMultiArgs(LuaTable table) => default; // 0x0000000183A400C0-0x0000000183A40410
		// [XID] // 0x000000018983AA20-0x000000018983AA40
		public object GetObjectField(object obj, string fieldName, int bindingFlags = -1 /* Metadata: 0x00AFEE78 */) => default; // 0x0000000183A430D0-0x0000000183A43220
		// [XID] // 0x0000000189842000-0x0000000189842020
		public object GetObjectFieldValue(object obj, string fieldName, int bindingFlags = -1 /* Metadata: 0x00AFEE7C */) => default; // 0x0000000183A42F60-0x0000000183A430D0
		// [XID] // 0x0000000189849500-0x0000000189849520
		public void SetObjectFieldValue(object obj, string fieldName, object newValue, int bindingFlags = -1 /* Metadata: 0x00AFEE80 */) {} // 0x0000000183A453F0-0x0000000183A45570
		// [XID] // 0x0000000189850D90-0x0000000189850DB0
		public object GetStaticClassField(string assemblyName, string className, string fieldName, int bindingFlags = -1 /* Metadata: 0x00AFEE84 */) => default; // 0x0000000183A43400-0x0000000183A435D0
		// [XID] // 0x0000000189858120-0x0000000189858140
		public object GetStaticClassFieldValue(string assemblyName, string className, string fieldName, int bindingFlags = -1 /* Metadata: 0x00AFEE88 */) => default; // 0x0000000183A43220-0x0000000183A43400
		// [XID] // 0x000000018985F1D0-0x000000018985F1F0
		public void SetStaticClassFieldValue(string assemblyName, string className, string fieldName, object newValue, int bindingFlags = -1 /* Metadata: 0x00AFEE8C */) {} // 0x0000000183A45570-0x0000000183A45760
		// [XID] // 0x00000001898669F0-0x0000000189866A10
		public object InvokeObjectMethod(object obj, string methodName, object arg, int bindingFlags = -1 /* Metadata: 0x00AFEE90 */) => default; // 0x0000000183A44660-0x0000000183A44860
		// [XID] // 0x000000018986E2B0-0x000000018986E2D0
		public object InvokeObjectMethodWithMultiArgs(object obj, string methodName, object[] args, int bindingFlags = -1 /* Metadata: 0x00AFEE94 */) => default; // 0x0000000183A44510-0x0000000183A44660
		// [XID] // 0x0000000189875760-0x0000000189875780
		public object InvokeStaticClassMethod(string assemblyName, string className, string methodName, object arg, int bindingFlags = -1 /* Metadata: 0x00AFEE98 */) => default; // 0x0000000183A44A40-0x0000000183A44CA0
		// [XID] // 0x000000018987D2B0-0x000000018987D2D0
		public object InvokeStaticClassMethodWithMultiArgs(string assemblyName, string className, string methodName, object[] args, int bindingFlags = -1 /* Metadata: 0x00AFEE9C */) => default; // 0x0000000183A44860-0x0000000183A44A40
		// [XID] // 0x00000001898841F0-0x0000000189884210
		private object ConvertLuaArgToCSharpArg(object arg, System.Type convertType) => default; // 0x0000000183A3EEA0-0x0000000183A3F400
		// [IDTag] // 0x000000018988B920-0x000000018988B960
		// [XID] // 0x000000018988B920-0x000000018988B960
		public object ChangeType(object value, System.Type conversionType) => default; // 0x0000000183A3E780-0x0000000183A3E870
		// [IDTag] // 0x0000000189895B60-0x0000000189895BA0
		// [XID] // 0x0000000189895B60-0x0000000189895BA0
		public object ChangeType(object value, string assemblyName, string className) => default; // 0x0000000183A3E870-0x0000000183A3E990
		// [IDTag] // 0x000000018989FFF0-0x00000001898A0030
		// [XID] // 0x000000018989FFF0-0x00000001898A0030
		public System.Type GetClassType(string assemblyName, string className) => default; // 0x0000000183A42D40-0x0000000183A42E30
		// [IDTag] // 0x00000001898AA660-0x00000001898AA6A0
		// [XID] // 0x00000001898AA660-0x00000001898AA6A0
		public System.Type GetClassType(string assemblyQualifiedName) => default; // 0x0000000183A42C40-0x0000000183A42D40
		// [IDTag] // 0x00000001898B4F40-0x00000001898B4F80
		// [XID] // 0x00000001898B4F40-0x00000001898B4F80
		public System.Type[] GetTypeArray(string argAssemblyName, string argClassName) => default; // 0x0000000183A43CF0-0x0000000183A43E60
		// [IDTag] // 0x00000001898BF860-0x00000001898BF8A0
		// [XID] // 0x00000001898BF860-0x00000001898BF8A0
		public System.Type[] GetTypeArray(string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName) => default; // 0x0000000183A435D0-0x0000000183A437A0
		// [IDTag] // 0x00000001898CA200-0x00000001898CA240
		// [XID] // 0x00000001898CA200-0x00000001898CA240
		public System.Type[] GetTypeArray(string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName, string arg3AssemblyName, string arg3ClassName) => default; // 0x0000000183A437A0-0x0000000183A43A00
		// [IDTag] // 0x00000001898D4870-0x00000001898D48B0
		// [XID] // 0x00000001898D4870-0x00000001898D48B0
		public System.Type[] GetTypeArray(string arg1AssemblyName, string arg1ClassName, string arg2AssemblyName, string arg2ClassName, string arg3AssemblyName, string arg3ClassName, string arg4AssemblyName, string arg4ClassName) => default; // 0x0000000183A43A00-0x0000000183A43CF0
		// [IDTag] // 0x00000001898DF710-0x00000001898DF750
		// [XID] // 0x00000001898DF710-0x00000001898DF750
		public object InvokeMethodImp(System.Type classType, string methodName, BindingFlags bf, object[] args) => default; // 0x0000000183A44280-0x0000000183A44510
		// [IDTag] // 0x00000001898EA1D0-0x00000001898EA210
		// [XID] // 0x00000001898EA1D0-0x00000001898EA210
		public object InvokeMethodImp(object obj, string methodName, BindingFlags bf, object[] args) => default; // 0x0000000183A43FC0-0x0000000183A44280
	}
}
