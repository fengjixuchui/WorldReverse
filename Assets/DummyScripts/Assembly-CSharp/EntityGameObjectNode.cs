/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityGameObjectNode // TypeDefIndex: 32024
{
	// Fields
	private GameObject _gameObject; // 0x10
	private Animator _animator; // 0x18
	private Rigidbody _rigidbody; // 0x20
	private bool _isKinematicRigidbody; // 0x28
	private uint _gameObjectResourceHandle; // 0x2C
	private MaterialGroup _defaultGroup; // 0x30
	private MaterialGroup _instancedMaterialGroup; // 0x38
	public EntityGameObjectNode prevNode; // 0x40
	public EntityGameObjectNode nextNode; // 0x48
	private int _index; // 0x50
	private uint _configId; // 0x54
	private const float RESET_GAME_OBJECT_Y_POSITION = -1000f; // Metadata: 0x00B13B78

	// Properties
	internal GameObject gameObject { /* [XID] */ /* 0x000000018971D390-0x000000018971D3B0 */ get => default; } // 0x000000018424F670-0x000000018424F710 
	internal Animator animator { /* [XID] */ /* 0x00000001899B5CE0-0x00000001899B5D00 */ get => default; } // 0x000000018424EEE0-0x000000018424EF80 
	internal Rigidbody rigidbody { /* [XID] */ /* 0x00000001899BDA00-0x00000001899BDA20 */ get => default; } // 0x000000018424EB00-0x000000018424EBA0 
	internal uint gameObjectResourceHandle { /* [XID] */ /* 0x00000001899C5120-0x00000001899C5140 */ get => default; } // 0x000000018424F530-0x000000018424F5D0 
	internal MaterialGroup defaultGroup { /* [XID] */ /* 0x00000001899CC7F0-0x00000001899CC810 */ get => default; } // 0x000000018424EBA0-0x000000018424EC40 
	internal MaterialGroup instancedMaterialGroup { /* [XID] */ /* 0x00000001899D3EA0-0x00000001899D3EC0 */ get => default; } // 0x000000018424EC40-0x000000018424ECE0 
	public int queryIndex { /* [XID] */ /* 0x00000001899DB470-0x00000001899DB490 */ get => default; /* [XID] */ /* 0x00000001899E2B70-0x00000001899E2B90 */ set {} } // 0x000000018424F5D0-0x000000018424F670 0x000000018424F710-0x000000018424F7C0
	public uint configId { /* [XID] */ /* 0x00000001899EA1D0-0x00000001899EA1F0 */ get => default; } // 0x000000018424F060-0x000000018424F100 

	// Constructors
	public EntityGameObjectNode() {} // 0x000000018424F7C0-0x000000018424F850

	// Methods
	// [XID] // 0x000000018999F4E0-0x000000018999F500
	public static EntityGameObjectNode Create(GameObject go, BaseEntity entity) => default; // 0x000000018424EF80-0x000000018424F060
	// [XID] // 0x00000001899A6FF0-0x00000001899A7010
	public static void Release(EntityGameObjectNode node) {} // 0x000000018424F470-0x000000018424F530
	// [XID] // 0x00000001899F1C60-0x00000001899F1C80
	internal void Init(GameObject go, BaseEntity entity) {} // 0x000000018424ECE0-0x000000018424EE10
	// [XID] // 0x00000001899F9440-0x00000001899F9460
	internal void Clear() {} // 0x000000018424EE10-0x000000018424EEE0
	// [XID] // 0x0000000189A00720-0x0000000189A00740
	public void ActiveGameObject() {} // 0x000000018424E790-0x000000018424E9B0
	// [XID] // 0x0000000189A08060-0x0000000189A08080
	public void ResetGameObject(bool isLightActive = true /* Metadata: 0x00B13B77 */) {} // 0x000000018424F100-0x000000018424F470
	// [XID] // 0x0000000189A0F460-0x0000000189A0F480
	public void DestroyGameObject() {} // 0x000000018424E9B0-0x000000018424EB00
}

