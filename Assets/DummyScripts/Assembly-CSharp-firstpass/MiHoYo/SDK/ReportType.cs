/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class ReportType // TypeDefIndex: 8914
	{
		// Fields
		public const string CODE_CREATE = "code_create"; // Metadata: 0x00AE4915
		public const string CODE_CREATE_TIME = "code_create_time"; // Metadata: 0x00AE4924
		public const string CODE_SCAN = "code_scan"; // Metadata: 0x00AE4938
		public const string CODE_LOGIN_SUCCESS = "code_login_success"; // Metadata: 0x00AE4945
		public const string CODE_LOGIN = "code_login"; // Metadata: 0x00AE495B
		public const string EVENT_ERROR = "event_error"; // Metadata: 0x00AE4969
		public const string EVENT_DISABLED_NO = "event_disabled_no"; // Metadata: 0x00AE4978
		public const string EVENT_DISABLED_LOCK = "event_disabled_lock"; // Metadata: 0x00AE498D
		public const string CONFIRM_LOGIN = "confirm_login"; // Metadata: 0x00AE49A4
		public const string CONFIRM_LOGIN_YES = "confirm_login_yes"; // Metadata: 0x00AE49B5
		public const string config_success = "config_success"; // Metadata: 0x00AE49CA
		public const string config_fail = "config_fail"; // Metadata: 0x00AE49DC
		public const string autologin = "autologin"; // Metadata: 0x00AE49EB
		public const string autologin_success = "autologin_success"; // Metadata: 0x00AE49F8
		public const string autologin_fail = "autologin_fail"; // Metadata: 0x00AE4A0D
		public const string sms_show = "sms_show"; // Metadata: 0x00AE4A1F
		public const string sms_send = "sms_send"; // Metadata: 0x00AE4A2B
		public const string sms_success = "sms_success"; // Metadata: 0x00AE4A37
		public const string passport_show = "passport_show"; // Metadata: 0x00AE4A46
		public const string passport_success = "passport_success"; // Metadata: 0x00AE4A57
		public const string player_show = "player_show"; // Metadata: 0x00AE4A6B
		public const string player_success = "player_success"; // Metadata: 0x00AE4A7A
		public const string system_show = "system_show"; // Metadata: 0x00AE4A8C
		public const string system_success = "system_success"; // Metadata: 0x00AE4A9B
		public const string guest_click = "guest_click"; // Metadata: 0x00AE4AAD
		public const string guest_verify = "guest_verify"; // Metadata: 0x00AE4ABC
		public const string guest_limit = "guest_limit"; // Metadata: 0x00AE4ACC
		public const string guest_success = "guest_success"; // Metadata: 0x00AE4ADB
		public const string guest_phone_show = "guest_phone_show"; // Metadata: 0x00AE4AEC
		public const string guest_phone_success = "guest_phone_success"; // Metadata: 0x00AE4B00
		public const string guest_email_show = "guest_email_show"; // Metadata: 0x00AE4B17
		public const string guest_email_registered_show = "guest_email_registered_show"; // Metadata: 0x00AE4B2B
		public const string guest_email_registered_success = "guest_email_registered_success"; // Metadata: 0x00AE4B4A
		public const string guest_email_unregistered_show = "guest_email_unregistered_show"; // Metadata: 0x00AE4B6C
		public const string guest_email_unregistered_success = "guest_email_unregistered_success"; // Metadata: 0x00AE4B8D
		public const string guest_phone_bind = "guest_phone_bind"; // Metadata: 0x00AE4BB1
		public const string guest_email_bind = "guest_email_bind"; // Metadata: 0x00AE4BC5
		public const string idcard_login_show = "idcard_login_show"; // Metadata: 0x00AE4BD9
		public const string idcard_login_success = "idcard_login_success"; // Metadata: 0x00AE4BEE
		public const string idcard_bind_show = "idcard_bind_show"; // Metadata: 0x00AE4C06
		public const string idcard_bind_success = "idcard_bind_success"; // Metadata: 0x00AE4C1A
		public const string idcard_pay_show = "idcard_pay_show"; // Metadata: 0x00AE4C31
		public const string idcard_pay_success = "idcard_pay_success"; // Metadata: 0x00AE4C44
		public const string payment_show = "payment_show"; // Metadata: 0x00AE4C5A
		public const string payment_createorder = "payment_createorder"; // Metadata: 0x00AE4C6A
		public const string init_success = "init_success"; // Metadata: 0x00AE4C81
		public const string init_fail = "init_fail"; // Metadata: 0x00AE4C91
		public const string agreement_show = "agreement_show"; // Metadata: 0x00AE4C9E
		public const string agreement_refuse = "agreement_refuse"; // Metadata: 0x00AE4CB0
		public const string agreement_agree = "agreement_agree"; // Metadata: 0x00AE4CC4
		public const string logout = "logout"; // Metadata: 0x00AE4CD7
		public const string logout_confirm = "logout_confirm"; // Metadata: 0x00AE4CE1
		public const string logout_cancel = "logout_cancel"; // Metadata: 0x00AE4CF3
		public const string login_phone_sms_click = "login_phone_sms_click"; // Metadata: 0x00AE4D04
		public const string login_phone_entergame_click = "login_phone_entergame_click"; // Metadata: 0x00AE4D1D
		public const string login_account_entergame_click = "login_account_entergame_click"; // Metadata: 0x00AE4D3C
		public const string login_account_forgot_click = "login_account_forgot_click"; // Metadata: 0x00AE4D5D
		public const string login_account_register_click = "login_account_register_click"; // Metadata: 0x00AE4D7B
		public const string bind_phone_sms_click = "bind_phone_sms_click"; // Metadata: 0x00AE4D9B
		public const string bind_phone_entergame_click = "bind_phone_entergame_click"; // Metadata: 0x00AE4DB3
		public const string bind_mail_register_click = "bind_mail_register_click"; // Metadata: 0x00AE4DD1
		public const string bind_mail_forgot_click = "bind_mail_forgot_click"; // Metadata: 0x00AE4DED
		public const string bind_mail_entergame_click = "bind_mail_entergame_click"; // Metadata: 0x00AE4E07
	
		// Constructors
		public ReportType() {} // 0x0000000185A89510-0x0000000185A8A470
	}
}
