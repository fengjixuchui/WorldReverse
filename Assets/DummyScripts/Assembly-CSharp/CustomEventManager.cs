/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CustomEventManager : GlobalManager, INotifyInterface // TypeDefIndex: 20693
{
	// Fields
	private Dictionary<CustomEventType, RegistNode> _curRegistListeners; // 0x10
	private Dictionary<ICustomEventListener, HashSet<RegistNode>> _curListenerRegistNode; // 0x18

	// Nested types
	public class RegistNode // TypeDefIndex: 20694
	{
		// Fields
		public CustomEventType eventType; // 0x10
		public RecycledLinkedList<ICustomEventListener> linkList; // 0x18
		public Dictionary<ICustomEventListener, RecycledLinkedList<ICustomEventListener>> nodeDic; // 0x20

		// Constructors
		public RegistNode() {} // 0x0000000182A587C0-0x0000000182A58870

		// Methods
		// [XID] // 0x0000000189AF7080-0x0000000189AF70A0
		public void Release() {} // 0x0000000182A58460-0x0000000182A58540
		// [XID] // 0x0000000189AFE6F0-0x0000000189AFE710
		public static RegistNode Get(CustomEventType type) => default; // 0x0000000182A583A0-0x0000000182A58460
		// [XID] // 0x0000000189B05F40-0x0000000189B05F60
		public bool TryAdd(ICustomEventListener listener) => default; // 0x0000000182A58280-0x0000000182A583A0
		// [XID] // 0x0000000189B0D650-0x0000000189B0D670
		public void TryRemove(ICustomEventListener listener) {} // 0x0000000182A58160-0x0000000182A58280
		// [XID] // 0x0000000189B14B70-0x0000000189B14B90
		public void TryTrigger(CustomEventType eventType, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] objParams) {} // 0x0000000182A58600-0x0000000182A587C0
		// [XID] // 0x0000000189B23A00-0x0000000189B23A20
		public bool IsEmpty() => default; // 0x0000000182A58540-0x0000000182A58600
	}

	// Constructors
	public CustomEventManager() {} // 0x0000000182A36E50-0x0000000182A36F00

	// Methods
	// [XID] // 0x0000000189A94CF0-0x0000000189A94D10
	public override void Init() {} // 0x0000000182A36960-0x0000000182A36A00
	// [XID] // 0x0000000189A9C550-0x0000000189A9C570
	public override void ClearOnLevelDestroy() {} // 0x0000000182A361B0-0x0000000182A36250
	// [XID] // 0x0000000189AA3CC0-0x0000000189AA3CE0
	public override void ReloadRes() {} // 0x0000000182A36DB0-0x0000000182A36E50
	// [XID] // 0x0000000189AAB250-0x0000000189AAB270
	public override void Destroy() {} // 0x0000000182A36250-0x0000000182A36590
	// [XID] // 0x0000000189AB2C60-0x0000000189AB2C80
	private void RegistNotify() {} // 0x0000000182A36590-0x0000000182A36670
	// [XID] // 0x0000000189ABA800-0x0000000189ABA820
	private void UnRegistNotify() {} // 0x0000000182A36670-0x0000000182A36750
	// [XID] // 0x0000000189AC20D0-0x0000000189AC20F0
	public bool OnNotify(Notify ntf) => default; // 0x0000000182A36CC0-0x0000000182A36DB0
	// [XID] // 0x0000000189AC9700-0x0000000189AC9720
	private void OnAvatarFetterExpChange(Notify ntf) {} // 0x0000000182A35DC0-0x0000000182A35F70
	// [XID] // 0x0000000189AD10F0-0x0000000189AD1110
	public void Regist(CustomEventType eventType, ICustomEventListener listener) {} // 0x0000000182A36A00-0x0000000182A36BB0
	// [XID] // 0x0000000189AD8EB0-0x0000000189AD8ED0
	public void UnRegist(CustomEventType eventType, ICustomEventListener listener) {} // 0x0000000182A36750-0x0000000182A36960
	// [XID] // 0x0000000189AE0980-0x0000000189AE09A0
	public void UnRegistAll(ICustomEventListener listener) {} // 0x0000000182A35F70-0x0000000182A361B0
	// [XID] // 0x0000000189AE7E50-0x0000000189AE7E70
	public void TriggerEvent(CustomEventType eventType, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] objParams) {} // 0x0000000182A36BB0-0x0000000182A36CC0
}

