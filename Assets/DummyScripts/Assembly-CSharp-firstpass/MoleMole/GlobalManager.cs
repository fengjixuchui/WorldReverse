/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	[Skip] // 0x0000000189622900-0x0000000189622910
	public abstract class GlobalManager : BaseManager // TypeDefIndex: 10487
	{
		// Constructors
		protected GlobalManager() {} // 0x0000000189BE5F90-0x0000000189BE5FF0
	
		// Methods
		public abstract void ClearOnLevelDestroy();
		// [XID] // 0x0000000189748810-0x0000000189748830
		public virtual void InitOnConnect() {} // 0x0000000189BE5EF0-0x0000000189BE5F90
		// [XID] // 0x0000000189757480-0x00000001897574A0
		public virtual void ClearOnDisconnect() {} // 0x0000000189BE5DB0-0x0000000189BE5E50
		// [XID] // 0x000000018974FDB0-0x000000018974FDD0
		public virtual void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AE764F */) {} // 0x0000000189BE5D00-0x0000000189BE5DB0
		public abstract void ReloadRes();
		// [XID] // 0x000000018975EC50-0x000000018975EC70
		public virtual void InitByLocalData() {} // 0x0000000189BE5E50-0x0000000189BE5EF0
	}
}
