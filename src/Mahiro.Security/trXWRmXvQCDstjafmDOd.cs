using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using u1vdmRXvUtEm4fOan3Mp;

namespace QrTK9YXvCnZSqLZ7SUO9;

internal class trXWRmXvQCDstjafmDOd
{
	internal static object PlcCLQZPTsUj2c0dGAsI;

	[MethodImpl((MethodImplOptions)8)]
	internal static string WWTXv4PHAua(object roomId, object statusPath, object sessionToken)
	{
		int num = 4;
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						array = (System.Text.Encoding.UTF8).GetBytes((string)sessionToken);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						array2 = System.Security.Cryptography.MD5.HashData(array);
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						text = System.Convert.ToBase64String((System.Text.Encoding.UTF8).GetBytes(JsonSerializer.Serialize<global::__f__AnonymousType45_5<string, string, string, string, string>>(new global::__f__AnonymousType45_5<string, string, string, string, string>((string)roomId, (string)statusPath, text2, text3, text4), (JsonSerializerOptions)null)));
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						break;
					case 1:
						try
						{
							text2 = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array))).ToLowerInvariant();
							int num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 990)
									{
										num4 = num5;
										continue;
									}
									goto case 2;
								case 2:
									text4 = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array2))).ToLowerInvariant();
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									text3 = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.ASCII).GetBytes((System.Convert.ToHexString(array)).ToLowerInvariant())))).ToLowerInvariant();
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
									{
										num4 = 2;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num6 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0262;
								}
								System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
								num6 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
								{
									num6 = 0;
								}
								continue;
								end_IL_0262:
								break;
							}
						}
						goto case 2;
					case 0:
						return PZYHyoXvhAXM3A3A3Q25.M7aXvr2LUFG(string.Concat("def __chronal_observe_local_lobby__(stage):\n    import base64\n    import json\n    import time\n    stage['value'] = 'lobby_import'\n    import tan_lobby_ctrl\n    from common import game\n\n    args = json.loads(base64.b64decode('", text, "'))\n    stage['value'] = 'timer'\n    timer = game.GetClient().GetClientCocosTimer()\n    if timer is None:\n        raise RuntimeError('local lobby observer is not ready')\n    deadline = time.time() + 60.0\n    state = {'finished': False}\n    previous = []\n\n    def credential_state():\n        result = {}\n        try:\n            import sys\n            setting = None\n            for module_name in ('setting', 'minecraft.setting', '_setting'):\n                candidate = sys.modules.get(module_name)\n                if (callable(getattr(candidate, 'get_login_token', None)) and\n                        callable(getattr(candidate, 'get_encryped_login_token', None))):\n                    setting = candidate\n                    break\n            if setting is None:\n                raise RuntimeError('credential getters are not ready')\n            login = setting.get_login_token()\n            key = setting.get_encryped_login_token()\n            if not isinstance(login, bytes):\n                login = login.encode('utf-8')\n            if not isinstance(key, bytes):\n                key = key.encode('utf-8')\n            result['login_bytes'] = len(login)\n            result['key_bytes'] = len(key)\n            # Hash support is optional in the embedded runtime. Keep lengths even if unavailable.\n            import hashlib\n            import binascii\n            def sha256(value):\n                return binascii.hexlify(hashlib.new('sha256', value).digest()).decode('ascii')\n            login_digest = sha256(login)\n            result['login_matches_session'] = login_digest == args['expected']\n            result['login_matches_session_hex'] = login_digest == args['expected_hex']\n            result['key_matches_session_md5'] = sha256(key) == args['expected_key']\n        except Exception as error:\n            result['credential_probe_failed'] = True\n            name = type(error).__name__\n            result['credential_probe_error'] = name if name in (\n                'ImportError', 'AttributeError', 'TypeError', 'ValueError', 'RuntimeError') else 'other'\n        return result\n\n    def write_status(phase, code=''):\n        result = {'phase': phase, 'code': code, 'observer_stage': stage['value']}\n        if phase == 'observer_error':\n            result['observer_error'] = code if code in (\n                'ImportError', 'AttributeError', 'TypeError', 'ValueError', 'RuntimeError',\n                'NameError', 'IOError', 'OSError') else 'other'\n        try:\n            ctrl = tan_lobby_ctrl.instance\n            lobby = getattr(ctrl, 'lobby', None)\n            result.update(credential_state())\n            result.update({\n                'lobby_created': lobby is not None,\n                'room_created': getattr(lobby, 'main_room', None) is not None,\n                'in_game': bool(getattr(ctrl, 'in_game', False))})\n        except Exception:\n            result['state_probe_failed'] = True\n        try:\n            with open(args['status_path'], 'w') as stream:\n                stream.write(json.dumps(result))\n        except Exception:\n            # Diagnostic I/O must not interrupt native callbacks or change connection results.\n            pass\n\n    def finish(phase, code=''):\n        if state['finished']:\n            return\n        state['finished'] = True\n        write_status(phase, code)\n        for ctrl, name, owned, original, wrapper in previous:\n            try:\n                if getattr(ctrl, name, None) is wrapper:\n                    if owned:\n                        setattr(ctrl, name, original)\n                    else:\n                        delattr(ctrl, name)\n            except Exception:\n                pass\n\n    def install_failure_observers(ctrl):\n        if ctrl is None or previous or not hasattr(ctrl, '__dict__'):\n            return\n        def install(name, phase, fallback):\n            original = getattr(ctrl, name, None)\n            if not callable(original):\n                return\n            def wrapper(*values, **kwargs):\n                code = fallback\n                if name == 'OnTanLobbyJoinRoomFail' and values:\n                    try:\n                        number = int(values[0])\n                        if -2147483648 <= number <= 2147483647:\n                            code = str(number)\n                    except (TypeError, ValueError, OverflowError):\n                        pass\n                try:\n                    finish(phase, code)\n                except Exception:\n                    pass\n                return original(*values, **kwargs)\n            owned = name in ctrl.__dict__\n            try:\n                setattr(ctrl, name, wrapper)\n                previous.append((ctrl, name, owned, original, wrapper))\n            except Exception:\n                pass\n        install('OnTanLobbyJoinRoomFail', 'rejected', 'native_join_failed')\n        install('_OnTanLobbyConnectRoomFail', 'failed', 'native_connect_failed')\n\n    def poll():\n        if state['finished']:\n            return\n        stage['value'] = 'poll'\n        try:\n            ctrl = tan_lobby_ctrl.instance\n            install_failure_observers(ctrl)\n            room = getattr(ctrl, 'lobby', None) and getattr(ctrl.lobby, 'main_room', None)\n            room_id = getattr(room, 'room_id', '') if room is not None else ''\n            if (getattr(ctrl, 'in_game', False) and str(room_id) == str(args['room_id'])):\n                finish('joined')\n                return\n            if time.time() >= deadline:\n                finish('timeout')\n                return\n            write_status('joining')\n            timer.addTimer(0.5, poll)\n        except Exception as error:\n            finish('observer_error', type(error).__name__)\n\n    stage['value'] = 'schedule'\n    install_failure_observers(tan_lobby_ctrl.instance)\n    write_status('joining')\n    try:\n        timer.addTimer(0.0, poll)\n    except Exception as error:\n        finish('observer_error', type(error).__name__)"), statusPath);
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			System.ArgumentException.ThrowIfNullOrEmpty((string)sessionToken, "sessionToken");
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Qpy8vLZPNqqcvRT3vC4T()
	{
		return PlcCLQZPTsUj2c0dGAsI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static trXWRmXvQCDstjafmDOd OlZOYOZPMVaBo6cvrmhj()
	{
		return (trXWRmXvQCDstjafmDOd)PlcCLQZPTsUj2c0dGAsI;
	}
}
