/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Sony.PS4.Dialog;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class SonyPS4CommonDialog : MonoBehaviour, IScreen // TypeDefIndex: 9752
{
	// Fields
	private MenuStack menuStack; // 0x18
	private float waitTime; // 0x20
	private float progressDelay; // 0x24
	private float progressTime; // 0x28
	private MenuLayout menuMain; // 0x30
	private MenuLayout menuUserMessage; // 0x38
	private MenuLayout menuSystemMessage1; // 0x40
	private MenuLayout menuErrorMessage; // 0x48
	private MenuLayout menuProgress; // 0x50

	// Constructors
	public SonyPS4CommonDialog() {} // 0x0000000186F25D20-0x0000000186F25D90

	// Methods
	private void Start() {} // 0x0000000186F25800-0x0000000186F25B90
	public void OnEnter() {} // 0x0000000186F25140-0x0000000186F25190
	public void OnExit() {} // 0x0000000186F25190-0x0000000186F251E0
	public void Process(MenuStack stack) {} // 0x0000000186F25700-0x0000000186F25800
	public void MenuMain() {} // 0x0000000186F249C0-0x0000000186F24C10
	private void MenuUserMessage() {} // 0x0000000186F24F30-0x0000000186F25140
	private void MenuSystemMessage1() {} // 0x0000000186F24D10-0x0000000186F24F30
	private void MenuErrorMessage() {} // 0x0000000186F248D0-0x0000000186F249C0
	private void MenuProgress() {} // 0x0000000186F24C10-0x0000000186F24D10
	private void OnGUI() {} // 0x0000000186F251E0-0x0000000186F25290
	private void OnLog(Messages.PluginMessage msg) {} // 0x0000000186F25670-0x0000000186F25700
	private void OnLogWarning(Messages.PluginMessage msg) {} // 0x0000000186F255A0-0x0000000186F25670
	private void OnLogError(Messages.PluginMessage msg) {} // 0x0000000186F254D0-0x0000000186F255A0
	private void OnGotDialogResult(Messages.PluginMessage msg) {} // 0x0000000186F25290-0x0000000186F25370
	private void OnGotIMEDialogResult(Messages.PluginMessage msg) {} // 0x0000000186F25370-0x0000000186F254D0
	private void Update() {} // 0x0000000186F25B90-0x0000000186F25D20
}

