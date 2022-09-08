/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCCollision : VCBase // TypeDefIndex: 11850
{
	// Fields
	public HashList<Action<Collision>> collisionEnterCallback; // 0x108
	public HashList<Action<Collision>> collisionStayCallback; // 0x110
	public HashList<Action<Collision>> collisionExitCallback; // 0x118
	public HashList<Action<Collider>> triggerEnterCallback; // 0x120
	public HashList<Action<Collider>> triggerStayCallback; // 0x128
	public HashList<Action<Collider>> triggerExitCallback; // 0x130
	private MonoCollisionHelper _collisionHelper; // 0x138

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B0B280-0x0000000189B0B2A0 */ get => default; } // 0x0000000182ED3670-0x0000000182ED3710 

	// Constructors
	public VCCollision() {} // 0x0000000182ED3590-0x0000000182ED3670

	// Methods
	// [XID] // 0x0000000189838A20-0x0000000189838A40
	public override void Init() {} // 0x0000000182ED2F10-0x0000000182ED3370
	// [XID] // 0x000000018985D120-0x000000018985D140
	public override void Destroy() {} // 0x0000000182ED2910-0x0000000182ED2DC0
	// [XID] // 0x000000018983FF60-0x000000018983FF80
	public void OnCollisionEnter(Collision collision) {} // 0x0000000182ED27C0-0x0000000182ED2910
	// [XID] // 0x00000001898475A0-0x00000001898475C0
	public void OnCollisionExit(Collision collision) {} // 0x0000000182ED2520-0x0000000182ED2670
	// [XID] // 0x0000000189B300B0-0x0000000189B300D0
	public void OnTriggerEnter(Collider other) {} // 0x0000000182ED2DC0-0x0000000182ED2F10
	// [XID] // 0x0000000189B37860-0x0000000189B37880
	public void OnTriggerStay(Collider other) {} // 0x0000000182ED2670-0x0000000182ED27C0
	// [XID] // 0x0000000189855E90-0x0000000189855EB0
	public void OnTriggerExit(Collider other) {} // 0x0000000182ED33D0-0x0000000182ED3520
}

