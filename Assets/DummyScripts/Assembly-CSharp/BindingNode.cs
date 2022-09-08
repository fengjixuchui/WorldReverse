/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BindingNode // TypeDefIndex: 20713
{
	// Fields
	private Transform _parent; // 0x10
	private Component _bindingComp; // 0x18
	private TrackAsset _trackAsset; // 0x20
	private GameObject _templateBindingGO; // 0x28
	private Vector3 _templatePos; // 0x30
	private Quaternion _templateRot; // 0x3C
	private double _startTime; // 0x50
	private double _endTime; // 0x58
	private bool _isActive; // 0x60

	// Properties
	public Transform parent { /* [XID] */ /* 0x0000000189645C20-0x0000000189645C40 */ get => default; } // 0x0000000182041C40-0x0000000182041CE0 
	public Component bindingComp { /* [XID] */ /* 0x000000018964D4A0-0x000000018964D4C0 */ get => default; } // 0x00000001820419D0-0x0000000182041A70 
	public TrackAsset trackAsset { /* [XID] */ /* 0x0000000189654D40-0x0000000189654D60 */ get => default; } // 0x0000000182041850-0x00000001820418F0 
	public GameObject templateBindingGO { /* [XID] */ /* 0x000000018965C290-0x000000018965C2B0 */ get => default; } // 0x0000000182041CE0-0x0000000182041D80 
	public Vector3 templatePos { /* [XID] */ /* 0x0000000189663A60-0x0000000189663A80 */ get => default; } // 0x00000001820416C0-0x00000001820417A0 
	public Quaternion templateRot { /* [XID] */ /* 0x000000018966B2E0-0x000000018966B300 */ get => default; } // 0x0000000182041D80-0x0000000182041E50 
	public double startTime { /* [XID] */ /* 0x0000000189672FE0-0x0000000189673000 */ get => default; } // 0x00000001820417A0-0x0000000182041850 
	public double endTime { /* [XID] */ /* 0x000000018967A5D0-0x000000018967A5F0 */ get => default; } // 0x0000000182041A70-0x0000000182041B20 
	public bool isActive { /* [XID] */ /* 0x0000000189681ED0-0x0000000189681EF0 */ get => default; } // 0x0000000182041E50-0x0000000182041EF0 

	// Constructors
	public BindingNode() {} // 0x0000000182041EF0-0x0000000182041F70

	// Methods
	public static BindingNode CreateBindingNode<T>(T bindingComponent, TrackAsset trackAsset, PlayableDirector director)
		where T : Component => default;
	public void Init<T>(T bindingComponent, TrackAsset trackAsset, PlayableDirector director)
		where T : Component {}
	// [XID] // 0x0000000189689920-0x0000000189689940
	private bool IsSelfActive() => default; // 0x0000000182041B20-0x0000000182041C40
	// [XID] // 0x0000000189691680-0x00000001896916A0
	public void Tick(float timeCnt) {} // 0x00000001820418F0-0x00000001820419D0
}

