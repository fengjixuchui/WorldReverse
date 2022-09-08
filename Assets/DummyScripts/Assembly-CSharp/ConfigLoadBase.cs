/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ConfigLoadBase : AsyncJobProxy // TypeDefIndex: 19464
{
	// Fields
	protected int _refCount; // 0x10
	private DoublyList<Action> _callbacks; // 0x18
	private Status _status; // 0x20
	private AsyncJob _asyncJob; // 0x28

	// Properties
	public Status status { /* [XID] */ /* 0x00000001899B8C70-0x00000001899B8C90 */ get; } // 0x00000001814D6A40-0x00000001814D6AE0 

	// Nested types
	public enum Status // TypeDefIndex: 19465
	{
		Release = 0,
		Loading = 1,
		Loaded = 2
	}

	// Constructors
	protected ConfigLoadBase() {} // 0x00000001814D7950-0x00000001814D79C0

	// Methods
	// [XID] // 0x0000000189A0CF20-0x0000000189A0CF40
	public bool CheckVoucher(object voucher) => default; // 0x00000001814D6BB0-0x00000001814D6CA0
	// [XID] // 0x0000000189A14700-0x0000000189A14720
	public void Dismiss(object callback) {} // 0x00000001814D6D60-0x00000001814D6E30
	// [XID] // 0x0000000189A1BA50-0x0000000189A1BA70
	public virtual string Dump() => default; // 0x00000001814D72B0-0x00000001814D73F0
	// [XID] // 0x0000000189A23380-0x0000000189A233A0
	public bool CheckRef() => default; // 0x00000001814D6990-0x00000001814D6A40
	// [XID] // 0x0000000189A31B00-0x0000000189A31B20
	public void SetLoading() {} // 0x00000001814D7060-0x00000001814D7100
	// [XID] // 0x0000000189A395F0-0x0000000189A39610
	public virtual void Clear() {} // 0x00000001814D6E30-0x00000001814D7060
	// [XID] // 0x0000000189A40D50-0x0000000189A40D70
	private void InternalCreateLoadPattern(ulong path, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded) {} // 0x00000001814D7100-0x00000001814D72B0
	// [XID] // 0x00000001898C1FA0-0x00000001898C1FC0
	private void CreateLoadPattern(ulong path, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded) {} // 0x00000001814D75D0-0x00000001814D76E0
	// [XID] // 0x0000000189A4FD00-0x0000000189A4FD20
	public AsyncJob CheckAsyncLoadWithJob(Action callback, ulong path, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded) => default; // 0x00000001814D67B0-0x00000001814D6990
	// [XID] // 0x0000000189A571F0-0x0000000189A57210
	private void BroadcastFinishCallback() {} // 0x00000001814D7780-0x00000001814D7950
	// [XID] // 0x0000000189A5ED50-0x0000000189A5ED70
	public virtual void AddRefCount() {} // 0x00000001814D7490-0x00000001814D7530
	// [XID] // 0x0000000189A665A0-0x0000000189A665C0
	public virtual void MinusRefCount() {} // 0x00000001814D7530-0x00000001814D75D0
	// [XID] // 0x00000001899A9CE0-0x00000001899A9D00
	private void Abort() {} // 0x00000001814D73F0-0x00000001814D7490
	// [XID] // 0x0000000189A75370-0x0000000189A75390
	protected virtual void CheckConfig() {} // 0x00000001814D76E0-0x00000001814D7780
	// [XID] // 0x0000000189A7D0D0-0x0000000189A7D0F0
	protected void onLoadFinish() {} // 0x00000001814D6AE0-0x00000001814D6BB0
	// [XID] // 0x0000000189A84900-0x0000000189A84920
	public void Recycle() {} // 0x00000001814D6CA0-0x00000001814D6D60
}

