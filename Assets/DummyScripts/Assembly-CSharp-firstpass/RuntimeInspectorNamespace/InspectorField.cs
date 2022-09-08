/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public abstract class InspectorField : MonoBehaviour // TypeDefIndex: 9989
	{
		// Fields
		private RuntimeInspector m_inspector; // 0x18
		private int m_skinVersion; // 0x20
		private UISkin m_skin; // 0x28
		private System.Type m_boundVariableType; // 0x30
		private object m_value; // 0x38
		private int m_depth; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected LayoutElement layoutElement; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text variableNameText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image variableNameMask; // 0x58
		private Getter getter; // 0x60
		private Setter setter; // 0x68
	
		// Properties
		public RuntimeInspector Inspector { /* [XID] */ /* 0x00000001895E9B60-0x00000001895E9B80 */ protected get; /* [XID] */ /* 0x0000000189689040-0x0000000189689060 */ set; } // 0x00000001867F7420-0x00000001867F74C0 0x00000001867F7940-0x00000001867F7A40
		public UISkin Skin { /* [XID] */ /* 0x0000000189690BE0-0x0000000189690C00 */ protected get; /* [XID] */ /* 0x00000001898DC6B0-0x00000001898DC6D0 */ set; } // 0x00000001867F7740-0x00000001867F77E0 0x00000001867F7CC0-0x00000001867F7E10
		protected System.Type BoundVariableType { /* [XID] */ /* 0x000000018969F7E0-0x000000018969F800 */ get; } // 0x00000001867F7230-0x00000001867F72D0 
		protected object Value { /* [XID] */ /* 0x00000001896E02B0-0x00000001896E02D0 */ get; /* [XID] */ /* 0x00000001898F2FA0-0x00000001898F2FC0 */ set; } // 0x00000001867F77E0-0x00000001867F7880 0x00000001867F7E10-0x00000001867F7EE0
		public int Depth { /* [XID] */ /* 0x00000001896B5760-0x00000001896B5780 */ protected get; /* [XID] */ /* 0x0000000189913880-0x00000001899138A0 */ set; } // 0x00000001867F72D0-0x00000001867F7370 0x00000001867F7880-0x00000001867F7940
		public string Name { /* [XID] */ /* 0x00000001896C4020-0x00000001896C4040 */ get; /* [XID] */ /* 0x00000001896CB460-0x00000001896CB480 */ set; } // 0x00000001867F7600-0x00000001867F7740 0x00000001867F7B50-0x00000001867F7CC0
		public string NameRaw { /* [XID] */ /* 0x00000001896D2A30-0x00000001896D2A50 */ get; /* [XID] */ /* 0x00000001896DA480-0x00000001896DA4A0 */ set; } // 0x00000001867F74C0-0x00000001867F7600 0x00000001867F7A40-0x00000001867F7B50
		protected virtual float HeightMultiplier { /* [XID] */ /* 0x0000000189651F60-0x0000000189651F80 */ get; } // 0x00000001867F7370-0x00000001867F7420 
	
		// Nested types
		public delegate object Getter(); // TypeDefIndex: 9990; 0x00000001867F09F0-0x00000001867F0B60
	
		public delegate void Setter(object value); // TypeDefIndex: 9991; 0x0000000186808460-0x00000001868086C0
	
		// Constructors
		protected InspectorField() {} // 0x00000001867F71C0-0x00000001867F7230
	
		// Methods
		public abstract bool SupportsType(System.Type type);
		// [XID] // 0x00000001896E9190-0x00000001896E91B0
		public virtual void Initialize() {} // 0x00000001867F6920-0x00000001867F69C0
		// [IDTag] // 0x00000001896F0230-0x00000001896F0270
		// [XID] // 0x00000001896F0230-0x00000001896F0270
		public void BindTo(InspectorField parent, MemberInfo member, string variableName = null) {} // 0x00000001867F6330-0x00000001867F6810
		// [IDTag] // 0x00000001896FAC90-0x00000001896FACD0
		// [XID] // 0x00000001896FAC90-0x00000001896FACD0
		public void BindTo(System.Type variableType, string variableName, Getter getter, Setter setter) {} // 0x00000001867F6810-0x00000001867F6920
		// [XID] // 0x00000001898B17B0-0x00000001898B17D0
		public void Unbind() {} // 0x00000001867F70E0-0x00000001867F71C0
		// [XID] // 0x000000018970C8E0-0x000000018970C900
		protected virtual void OnBound() {} // 0x00000001867F69C0-0x00000001867F6A60
		// [XID] // 0x00000001898C7E80-0x00000001898C7EA0
		protected virtual void OnUnbound() {} // 0x00000001867F6E90-0x00000001867F6F30
		// [XID] // 0x00000001898FCD20-0x00000001898FCD40
		protected virtual void OnInspectorChanged() {} // 0x00000001867F6BD0-0x00000001867F6C70
		// [XID] // 0x0000000189722F20-0x0000000189722F40
		protected virtual void OnSkinChanged() {} // 0x00000001867F6C70-0x00000001867F6E90
		// [XID] // 0x000000018994F270-0x000000018994F290
		protected virtual void OnDepthChanged() {} // 0x00000001867F6A60-0x00000001867F6BD0
		// [XID] // 0x0000000189731E20-0x0000000189731E40
		public virtual void Refresh() {} // 0x00000001867F7040-0x00000001867F70E0
		// [XID] // 0x000000018996D230-0x000000018996D250
		private void RefreshValue() {} // 0x00000001867F6F30-0x00000001867F7040
	}
}
