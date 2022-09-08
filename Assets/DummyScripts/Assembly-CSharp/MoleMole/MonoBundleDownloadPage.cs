/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBundleDownloadPage : MonoBehaviour // TypeDefIndex: 30292
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _branchText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _versionText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _progressText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _speedText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoProgressBar _progressBar; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _pauseText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _pauseIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _bgBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _playBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minProcessTime; // 0x68
		public bool isProgressShow; // 0x6C
	
		// Properties
		public UnityEngine.UI.Text branchText { /* [XID] */ /* 0x0000000189B50050-0x0000000189B50070 */ get => default; } // 0x0000000184802150-0x00000001848021F0 
		public UnityEngine.UI.Text descText { /* [XID] */ /* 0x0000000189B57880-0x0000000189B578A0 */ get => default; } // 0x00000001848021F0-0x0000000184802290 
		public UnityEngine.UI.Text versionText { /* [XID] */ /* 0x0000000189B5F1F0-0x0000000189B5F210 */ get => default; } // 0x0000000184802700-0x00000001848027A0 
		public UnityEngine.UI.Text progressText { /* [XID] */ /* 0x0000000189B66800-0x0000000189B66820 */ get => default; } // 0x00000001848025C0-0x0000000184802660 
		public UnityEngine.UI.Text speedText { /* [XID] */ /* 0x0000000189B6DD40-0x0000000189B6DD60 */ get => default; } // 0x0000000184802660-0x0000000184802700 
		public MonoProgressBar progressBar { /* [XID] */ /* 0x0000000189B75410-0x0000000189B75430 */ get => default; } // 0x0000000184802520-0x00000001848025C0 
		public float minProcessTime { /* [XID] */ /* 0x0000000189B7C860-0x0000000189B7C880 */ get => default; } // 0x0000000184802290-0x0000000184802340 
		public GameObject pauseText { /* [XID] */ /* 0x0000000189B846A0-0x0000000189B846C0 */ get => default; } // 0x00000001848023E0-0x0000000184802480 
		public GameObject pauseIcon { /* [XID] */ /* 0x0000000189B8B530-0x0000000189B8B550 */ get => default; } // 0x0000000184802340-0x00000001848023E0 
		public MonoUIContainer playBtn { /* [XID] */ /* 0x0000000189B92C60-0x0000000189B92C80 */ get => default; } // 0x0000000184802480-0x0000000184802520 
		public Button bgBtn { /* [XID] */ /* 0x0000000189B9A240-0x0000000189B9A260 */ get => default; } // 0x00000001848020B0-0x0000000184802150 
	
		// Constructors
		public MonoBundleDownloadPage() {} // 0x0000000184802010-0x00000001848020B0
	}
}
