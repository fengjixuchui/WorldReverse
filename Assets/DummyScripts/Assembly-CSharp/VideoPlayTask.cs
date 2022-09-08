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

public class VideoPlayTask // TypeDefIndex: 21377
{
	// Fields
	private string _videoPath; // 0x10
	private string _subtitlePath; // 0x18
	private Action _videoStartAction; // 0x20
	private Action _videoFinishAction; // 0x28
	private Action _videoErrorAction; // 0x30
	private Action<int, string[]> _videoEventCallBack; // 0x38
	private bool _canSkip; // 0x40
	private bool _forceSkip; // 0x41
	private bool _dontPauseGameLogic; // 0x42
	private Color _bgColor; // 0x44
	private float _fadeInTime; // 0x54
	private float _fadeOutTime; // 0x58

	// Properties
	public string videoPath { /* [XID] */ /* 0x00000001899BF690-0x00000001899BF6B0 */ get => default; } // 0x00000001814CE660-0x00000001814CE700 
	public string subtitlePath { /* [XID] */ /* 0x00000001899C7030-0x00000001899C7050 */ get => default; } // 0x00000001814CEC50-0x00000001814CECF0 
	public Action videoStartAction { /* [XID] */ /* 0x00000001899CE4D0-0x00000001899CE4F0 */ get => default; } // 0x00000001814CE700-0x00000001814CE7A0 
	public Action videoFinishAction { /* [XID] */ /* 0x00000001899D5C70-0x00000001899D5C90 */ get => default; } // 0x00000001814CE840-0x00000001814CE8E0 
	public Action videoErrorAction { /* [XID] */ /* 0x00000001899DD040-0x00000001899DD060 */ get => default; } // 0x00000001814CE520-0x00000001814CE5C0 
	public Action<int, string[]> videoEventCallBack { /* [XID] */ /* 0x00000001899E4C00-0x00000001899E4C20 */ get => default; } // 0x00000001814CE990-0x00000001814CEA30 
	public bool canSkip { /* [XID] */ /* 0x00000001899EC110-0x00000001899EC130 */ get => default; } // 0x00000001814CE5C0-0x00000001814CE660 
	public bool forceSkip { /* [XID] */ /* 0x00000001899F3B10-0x00000001899F3B30 */ get => default; } // 0x00000001814CE7A0-0x00000001814CE840 
	public bool dontPauseGameLogic { /* [XID] */ /* 0x00000001899FB3F0-0x00000001899FB410 */ get => default; } // 0x00000001814CEA30-0x00000001814CEAD0 
	public Color bgColor { /* [XID] */ /* 0x0000000189A02610-0x0000000189A02630 */ get => default; } // 0x00000001814CEB80-0x00000001814CEC50 
	public float fadeInTime { /* [XID] */ /* 0x0000000189A09DA0-0x0000000189A09DC0 */ get => default; } // 0x00000001814CEAD0-0x00000001814CEB80 
	public float fadeOutTime { /* [XID] */ /* 0x0000000189A11620-0x0000000189A11640 */ get => default; } // 0x00000001814CE8E0-0x00000001814CE990 

	// Constructors
	public VideoPlayTask() {} // Dummy constructor
	public VideoPlayTask(string videoPath, string subtitlePath = null, bool canSkip = true /* Metadata: 0x00AFF6EC */, Action startAction = null, Action finishAction = null, Action errorAction = null, Color? bgColor = default, bool forceSkip = false /* Metadata: 0x00AFF6ED */, float fadeIn = 0f /* Metadata: 0x00AFF6EE */, float fadeOut = 0f /* Metadata: 0x00AFF6F2 */, Action<int, string[]> eventCallBack = null, bool dontPauseLogic = false /* Metadata: 0x00AFF6F6 */) {} // 0x00000001814CECF0-0x00000001814CEE60
}

