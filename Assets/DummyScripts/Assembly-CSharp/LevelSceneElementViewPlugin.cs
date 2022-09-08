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
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneElementViewPlugin : BaseComponentPlugin // TypeDefIndex: 12081
{
	// Fields
	public static int ElementPropID; // 0x00
	public static Dictionary<ElementType, int> Element2ColorID; // 0x08
	private bool _triggerElementView; // 0x58
	private float _keepElementViewTime; // 0x5C
	private const float CHECK_ELEMENT_VIEW_AUTO_QUIT_TIME_THRESHOLD = 2.5f; // Metadata: 0x00AEB4AC
	private ElementView _elementViewSetting; // 0x60
	private float _transition; // 0x68
	private const float TRANSITION_SPEED = 5f; // Metadata: 0x00AEB4B0
	public Action onStartElementView; // 0x70
	public Action onFinishElementView; // 0x78

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189ADB0F0-0x0000000189ADB110 */ get => default; } // 0x0000000182233A70-0x0000000182233B10 
	public bool inElementView { /* [XID] */ /* 0x0000000189AEA2F0-0x0000000189AEA310 */ get => default; } // 0x0000000182231D40-0x0000000182231DF0 

	// Constructors
	public LevelSceneElementViewPlugin() {} // 0x0000000182233A10-0x0000000182233A70
	static LevelSceneElementViewPlugin() {} // 0x0000000182233960-0x0000000182233A10

	// Methods
	// [XID] // 0x0000000189AE27C0-0x0000000189AE27E0
	private bool CheckElementViewSetting() => default; // 0x0000000182231DF0-0x0000000182231FF0
	// [XID] // 0x0000000189AF1E10-0x0000000189AF1E30
	public override void Init() {} // 0x00000001822325A0-0x0000000182232930
	// [XID] // 0x0000000189AF97E0-0x0000000189AF9800
	public override void Tick(float inDeltaTime) {} // 0x0000000182233120-0x0000000182233960
	// [XID] // 0x0000000189B00C10-0x0000000189B00C30
	private bool CheckElementViewAutoQuit() => default; // 0x0000000182232B20-0x0000000182232CB0
	// [XID] // 0x0000000189B08210-0x0000000189B08230
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001822324D0-0x00000001822325A0
	// [XID] // 0x0000000189B0FA70-0x0000000189B0FA90
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182232930-0x0000000182232B20
	// [XID] // 0x0000000189B16C80-0x0000000189B16CA0
	public void TriggerElementView(bool trigger) {} // 0x0000000182232D20-0x0000000182232F10
	// [XID] // 0x0000000189B1E4A0-0x0000000189B1E4C0
	private bool OnEntityModifierChanged(uint entityRuntimeID) => default; // 0x0000000182231C30-0x0000000182231D40
	// [XID] // 0x0000000189B25DA0-0x0000000189B25DC0
	private void CheckAllEntitiesModifiers() {} // 0x00000001822322C0-0x00000001822324D0
	// [XID] // 0x0000000189B2D0D0-0x0000000189B2D0F0
	private void UpdateEntityElementView(BaseEntity entity) {} // 0x0000000182231FF0-0x00000001822321C0
	// [XID] // 0x0000000189B345D0-0x0000000189B345F0
	private bool IsElementViewEntity(BaseEntity entity) => default; // 0x0000000182232F10-0x0000000182233120
}

