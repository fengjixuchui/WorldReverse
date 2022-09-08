/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FaceShadowTextureManager // TypeDefIndex: 26497
{
	// Fields
	private SortedDictionary<int, Texture2D> _texName2TexDict; // 0x10
	private Dictionary<int, uint> _texName2HandleDict; // 0x18
	private LinkedList<int> _textureLinkList; // 0x20
	private Dictionary<Texture2D, LinkedListNode<int>> _tex2LinkListNodeDict; // 0x28
	private int _maxTexsInMemory; // 0x30
	private Texture2D _curTex2D; // 0x38
	private bool _isInAsyncLodingState; // 0x40
	private GameObject _go; // 0x48
	private CoroutineBehaviourUsedInFaceShadow _behaviourForCoroutine; // 0x50
	private static readonly string COMPRESSED_PICS_FOLDER; // 0x00
	private static readonly int[] COMPRESSED_ANGLES_LIST_ALL; // 0x08
	private static readonly int[] CHOSED_ANGLES_LIST; // 0x10
	private int[] _anglesInTextureList; // 0x58

	// Constructors
	private FaceShadowTextureManager() {} // 0x0000000182CA7960-0x0000000182CA7B70
	static FaceShadowTextureManager() {} // 0x0000000182CA7860-0x0000000182CA7960

	// Methods
	// [XID] // 0x00000001898E2490-0x00000001898E24B0
	public Texture2D GetTexture2D(int angle, ref int isUsingRG, ref int xAngleChosed) => default; // 0x0000000182CA5F10-0x0000000182CA6190
	// [XID] // 0x00000001898EA020-0x00000001898EA040
	public void SetMaxTextureNumInMemory(int num) {} // 0x0000000182CA6830-0x0000000182CA6900
	// [XID] // 0x00000001898F1800-0x00000001898F1820
	public void InitAtAwake() {} // 0x0000000182CA6190-0x0000000182CA6230
	// [XID] // 0x00000001898F8F80-0x00000001898F8FA0
	public void InitAtStart() {} // 0x0000000182CA6BA0-0x0000000182CA6C40
	// [XID] // 0x00000001899008C0-0x00000001899008E0
	public void Core() {} // 0x0000000182CA7160-0x0000000182CA72E0
	// [XID] // 0x0000000189908100-0x0000000189908120
	public void Destroy() {} // 0x0000000182CA6230-0x0000000182CA65A0
	// [XID] // 0x000000018990F840-0x000000018990F860
	private void AddTextureToManager(Texture2D tex, int stateImageID, uint texResourceHandle) {} // 0x0000000182CA5D70-0x0000000182CA5F10
	[DebuggerHidden] // 0x0000000189917310-0x0000000189917350
	// [XID] // 0x0000000189917310-0x0000000189917350
	private IEnumerator LoadTextureToManagerAsync(int stateImageID) => default; // 0x0000000182CA65A0-0x0000000182CA66C0
	// [XID] // 0x0000000189921B20-0x0000000189921B40
	private void MoveTextureToListHead() {} // 0x0000000182CA66C0-0x0000000182CA6830
	// [XID] // 0x0000000189929240-0x0000000189929260
	private void RemoveTextureFromManger() {} // 0x0000000182CA6900-0x0000000182CA6BA0
	// [XID] // 0x0000000189930840-0x0000000189930860
	private void FindNearestTextureInList(int angle, ref int isUsingRG, ref int xAngleChosed) {} // 0x0000000182CA6C40-0x0000000182CA7160
	// [XID] // 0x0000000189937D20-0x0000000189937D40
	private int FindNearestAngleIndexInAnglesArray(int angle, int[] angleArray) => default; // 0x0000000182CA76C0-0x0000000182CA7860
	// [XID] // 0x000000018993F7D0-0x000000018993F7F0
	public void ShowTexturesInList() {} // 0x0000000182CA72E0-0x0000000182CA76C0
}

