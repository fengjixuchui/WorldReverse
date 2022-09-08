/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[Serializable]
	public class GaiaSession : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 9303
	{
		// Fields
		// [TextArea] // 0x0000000189619CF0-0x0000000189619D10
		public string m_name; // 0x18
		// [TextArea] // 0x0000000189621190-0x00000001896211B0
		public string m_description; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Texture2D m_previewImage; // 0x28
		public string m_dateCreated; // 0x30
		public int m_terrainWidth; // 0x38
		public int m_terrainDepth; // 0x3C
		public int m_terrainHeight; // 0x40
		public float m_seaLevel; // 0x44
		public bool m_isLocked; // 0x48
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public ScriptableObjectWrapper m_defaults; // 0x50
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<string, ScriptableObjectWrapper> m_resources; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<string> m_resourcesKeys; // 0x60
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<ScriptableObjectWrapper> m_resourcesValues; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public byte[] m_previewImageBytes; // 0x70
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int m_previewImageWidth; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int m_previewImageHeight; // 0x7C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<GaiaOperation> m_operations; // 0x80
	
		// Constructors
		public GaiaSession() {} // 0x0000000185EBF3A0-0x0000000185EBF5A0
	
		// Methods
		// [XID] // 0x000000018966BF40-0x000000018966BF60
		public void OnBeforeSerialize() {} // 0x0000000185EBF150-0x0000000185EBF3A0
		// [XID] // 0x0000000189673CF0-0x0000000189673D10
		public void OnAfterDeserialize() {} // 0x0000000185EBEFB0-0x0000000185EBF150
		// [XID] // 0x000000018967B500-0x000000018967B520
		public string GetSessionFileName() => default; // 0x0000000185EBEF00-0x0000000185EBEFB0
		// [XID] // 0x0000000189682CB0-0x0000000189682CD0
		public Texture2D GetPreviewImage() => default; // 0x0000000185EBEDC0-0x0000000185EBEF00
	}
}
