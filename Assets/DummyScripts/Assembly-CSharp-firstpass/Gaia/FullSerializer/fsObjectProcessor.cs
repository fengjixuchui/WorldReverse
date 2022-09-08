/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public abstract class fsObjectProcessor // TypeDefIndex: 9258
	{
		// Constructors
		protected fsObjectProcessor() {} // 0x0000000186B580D0-0x0000000186B58130
	
		// Methods
		// [XID] // 0x00000001896D09A0-0x00000001896D09C0
		public virtual bool CanProcess(System.Type type) => default; // 0x0000000186B57C10-0x0000000186B57CF0
		// [XID] // 0x000000018976F060-0x000000018976F080
		public virtual void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000186B58010-0x0000000186B580D0
		// [XID] // 0x0000000189623560-0x0000000189623580
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000186B57DB0-0x0000000186B57E80
		// [XID] // 0x0000000189A4CAC0-0x0000000189A4CAE0
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x0000000186B57F50-0x0000000186B58010
		// [XID] // 0x00000001897859A0-0x00000001897859C0
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x0000000186B57E80-0x0000000186B57F50
		// [XID] // 0x00000001899FB590-0x00000001899FB5B0
		public virtual void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000186B57CF0-0x0000000186B57DB0
	}
}
