/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	public class VirtualMachine // TypeDefIndex: 5065
	{
		// Fields
		internal ObjectClone objectClone; // 0x10
		private unsafe Instruction** unmanagedCodes; // 0x18
		private ExceptionHandler[][] exceptionHandlers; // 0x20
		private Action onDispose; // 0x28
		private ExternInvoker[] externInvokers; // 0x30
		private MethodBase[] externMethods; // 0x38
		private System.Type[] externTypes; // 0x40
		private string[] internStrings; // 0x48
		internal FieldInfo[] fieldInfos; // 0x50
		private AnonymousStoreyInfo[] anonymousStoreyInfos; // 0x58
		private Dictionary<System.Type, Dictionary<MethodInfo, MethodInfo>> overrideCache; // 0x60
		internal System.Type[] staticFieldTypes; // 0x68
		internal object[] staticFields; // 0x70
		private int[] cctors; // 0x78
		private WrappersManager wrappersManager; // 0x80
		public static Action<string> Info; // 0x00
	
		// Properties
		public ExceptionHandler[][] ExceptionHandlers { set {} } // 0x0000000189426E00-0x0000000189426E60
		public System.Type[] ExternTypes { set {} } // 0x0000000189426F00-0x0000000189426F60
		public MethodBase[] ExternMethods { set {} } // 0x0000000189426E60-0x0000000189426F00
		public string[] InternStrings { set {} } // 0x0000000189426FC0-0x0000000189427020
		public FieldInfo[] FieldInfos { set {} } // 0x0000000189426F60-0x0000000189426FC0
		public AnonymousStoreyInfo[] AnonymousStoreyInfos { set {} } // 0x0000000189426D40-0x0000000189426DA0
		public System.Type[] StaticFieldTypes { set {} } // 0x0000000189427020-0x00000001894270C0
		public int[] Cctors { set {} } // 0x0000000189426DA0-0x0000000189426E00
		public WrappersManager WrappersManager { set {} } // 0x00000001894270C0-0x0000000189427130
	
		// Constructors
		public VirtualMachine() {} // Dummy constructor
		internal unsafe VirtualMachine(Instruction** unmanaged_codes, Action on_dispose) {} // 0x0000000189425FD0-0x0000000189426090
		static VirtualMachine() {} // 0x0000000189425F30-0x0000000189425FD0
	
		// Methods
		~VirtualMachine() {} // 0x0000000189425DA0-0x0000000189425E60
		private unsafe void checkCctorExecute(int fieldId, Value* argumentBase, object[] managedStack, Value* evaluationStackBase) {} // 0x0000000189426910-0x0000000189426A70
		// [Il2CppSetOption] // 0x000000018971D450-0x000000018971D520
		// [Il2CppSetOption] // 0x000000018971D450-0x000000018971D520
		// [Il2CppSetOption] // 0x000000018971D450-0x000000018971D520
		private unsafe void store(Value* stackBase, Value* dst, Value* src, object[] managedStack) {} // 0x0000000189427130-0x00000001894272E0
		// [Il2CppSetOption] // 0x0000000189733720-0x00000001897337F0
		// [Il2CppSetOption] // 0x0000000189733720-0x00000001897337F0
		// [Il2CppSetOption] // 0x0000000189733720-0x00000001897337F0
		private unsafe void copy(Value* stackBase, Value* dst, Value* src, object[] managedStack) {} // 0x0000000189426A70-0x0000000189426C10
		public void Execute(int methodIndex, ref Call call, int argsCount, int refCount = 0 /* Metadata: 0x00ADAA98 */) {} // 0x000000018941BE40-0x000000018941BF60
		public unsafe Value* Execute(int methodIndex, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount) => default; // 0x000000018941BD50-0x000000018941BE40
		private void throwRuntimeException(Exception e, bool bWrap) {} // 0x00000001894272E0-0x0000000189427400
		private ExceptionHandler getExceptionHandler(int methodIndex, System.Type exceptionType, int pc) => default; // 0x0000000189426C10-0x0000000189426D40
		private unsafe void arrayGet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase) {} // 0x0000000189426090-0x00000001894264D0
		private unsafe void arraySet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase) {} // 0x00000001894264D0-0x0000000189426910
		public static void _Info(string a) {} // 0x0000000189425E60-0x0000000189425F30
		public unsafe Value* Execute(Instruction* pc, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount, int methodIndex, int refCount = 0 /* Metadata: 0x00ADAA9C */, Value** topWriteBack = null) => default; // 0x000000018941BF60-0x0000000189425DA0
	}
}
