using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Services;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Builder;

internal sealed class McpBuilderService
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BuildAsync_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<McpBuildResult> __t__builder;

		public McpBuildOptions options;

		public IProgress<string> progress;

		public CancellationToken cancellationToken;

		private string _outputPath_5__2;

		private string _temporaryOutputPath_5__3;

		private string _helperDirectory_5__4;

		private string _temporaryDirectory_5__5;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter __u__2;

		internal static object bei3etL21roCSUon4RMu;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_105a: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			//IL_1008: Expected I4, but got O
			//IL_0eef: Expected I4, but got O
			//IL_1171: Expected O, but got I4
			//IL_0df3: Expected I4, but got O
			//IL_107b: Expected I4, but got O
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f85: Expected I4, but got O
			//IL_0e5e: Expected I4, but got O
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0421: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I4
			//IL_078a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0791: Expected O, but got Unknown
			//IL_04f4: Expected O, but got I4
			//IL_00fa: Expected I4, but got O
			//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6b: Expected O, but got Unknown
			//IL_0a8f: Expected O, but got I4
			//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c2: Expected O, but got Unknown
			//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_095a: Expected O, but got I4
			//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a19: Expected O, but got Unknown
			//IL_0758: Unknown result type (might be due to invalid IL or missing references)
			//IL_0763: Unknown result type (might be due to invalid IL or missing references)
			//IL_076a: Expected O, but got Unknown
			//IL_090c: Expected O, but got I4
			//IL_0813: Expected O, but got I4
			//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a44: Expected O, but got Unknown
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b1: Expected I4, but got O
			//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe2->IL0fff: Incompatible stack types: I4 vs O
			//IL_0ec9->IL0ee6: Incompatible stack types: I4 vs O
			//IL_104c->IL105e: Incompatible stack types: I4 vs O
			//IL_0fed->IL0fff: Incompatible stack types: I4 vs O
			//IL_0ed4->IL0ee6: Incompatible stack types: I4 vs O
			//IL_0dc1->IL0dde: Incompatible stack types: I4 vs O
			//IL_0dcc->IL0dde: Incompatible stack types: I4 vs O
			//IL_1122->IL105e: Incompatible stack types: I4 vs O
			//IL_1106->IL105e: Incompatible stack types: I4 vs O
			//IL_113d->IL105e: Incompatible stack types: I4 vs O
			//IL_0f26->IL0dde: Incompatible stack types: I4 vs O
			//IL_1111->IL105e: Incompatible stack types: I4 vs O
			//IL_1148->IL105e: Incompatible stack types: I4 vs O
			//IL_0f31->IL0dde: Incompatible stack types: I4 vs O
			//IL_11cd->IL0010: Incompatible stack types: I4 vs O
			//IL_1185->IL0010: Incompatible stack types: I4 vs O
			//IL_11b2->IL0010: Incompatible stack types: I4 vs O
			//IL_0f5b->IL0f78: Incompatible stack types: I4 vs O
			//IL_0e95->IL0e4d: Incompatible stack types: I4 vs O
			//IL_0e30->IL0e4d: Incompatible stack types: I4 vs O
			//IL_11d8->IL0010: Incompatible stack types: I4 vs O
			//IL_1190->IL0010: Incompatible stack types: I4 vs O
			//IL_0077->IL0010: Incompatible stack types: I4 vs O
			//IL_0f66->IL0f78: Incompatible stack types: I4 vs O
			//IL_0ea0->IL0e4d: Incompatible stack types: I4 vs O
			//IL_0e3b->IL0e4d: Incompatible stack types: I4 vs O
			//IL_04d4->IL00b9: Incompatible stack types: I4 vs O
			//IL_00a7->IL00b9: Incompatible stack types: I4 vs O
			//IL_0082->IL0010: Incompatible stack types: I4 vs O
			//IL_0fbd->IL0f78: Incompatible stack types: I4 vs O
			//IL_0fc8->IL0f78: Incompatible stack types: I4 vs O
			//IL_02f7->IL00b9: Incompatible stack types: I4 vs O
			//IL_0171->IL00b9: Incompatible stack types: I4 vs O
			//IL_0210->IL00b9: Incompatible stack types: I4 vs O
			//IL_0130->IL00b9: Incompatible stack types: I4 vs O
			//IL_0287->IL00b9: Incompatible stack types: I4 vs O
			//IL_03a4->IL00b9: Incompatible stack types: I4 vs O
			//IL_02dc->IL00b9: Incompatible stack types: I4 vs O
			//IL_0475->IL00b9: Incompatible stack types: I4 vs O
			//IL_049b->IL00b9: Incompatible stack types: I4 vs O
			//IL_021b->IL00b9: Incompatible stack types: I4 vs O
			//IL_013b->IL00b9: Incompatible stack types: I4 vs O
			//IL_024a->IL00b9: Incompatible stack types: I4 vs O
			//IL_03af->IL00b9: Incompatible stack types: I4 vs O
			//IL_0480->IL00b9: Incompatible stack types: I4 vs O
			//IL_0349->IL00b9: Incompatible stack types: I4 vs O
			//IL_04e6->IL04f8: Incompatible stack types: I4 vs O
			//IL_0255->IL00b9: Incompatible stack types: I4 vs O
			//IL_0354->IL00b9: Incompatible stack types: I4 vs O
			//IL_0a7f->IL04f8: Incompatible stack types: I4 vs O
			//IL_0add->IL04f8: Incompatible stack types: I4 vs O
			//IL_070e->IL04f8: Incompatible stack types: I4 vs O
			//IL_0691->IL04f8: Incompatible stack types: I4 vs O
			//IL_05f9->IL04f8: Incompatible stack types: I4 vs O
			//IL_0aa8->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b00->IL04f8: Incompatible stack types: I4 vs O
			//IL_08d6->IL04f8: Incompatible stack types: I4 vs O
			//IL_06d7->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a3b->IL04f8: Incompatible stack types: I4 vs O
			//IL_09bc->IL04f8: Incompatible stack types: I4 vs O
			//IL_0668->IL04f8: Incompatible stack types: I4 vs O
			//IL_0803->IL04f8: Incompatible stack types: I4 vs O
			//IL_0973->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b12->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a23->IL04f8: Incompatible stack types: I4 vs O
			//IL_077e->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a05->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b25->IL04f8: Incompatible stack types: I4 vs O
			//IL_091b->IL04f8: Incompatible stack types: I4 vs O
			//IL_082c->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a58->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b9c->IL04f8: Incompatible stack types: I4 vs O
			//IL_09ce->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a8a->IL04f8: Incompatible stack types: I4 vs O
			//IL_089a->IL04f8: Incompatible stack types: I4 vs O
			//IL_0ae8->IL04f8: Incompatible stack types: I4 vs O
			//IL_0c3c->IL04f8: Incompatible stack types: I4 vs O
			//IL_099f->IL04f8: Incompatible stack types: I4 vs O
			//IL_0719->IL04f8: Incompatible stack types: I4 vs O
			//IL_069c->IL04f8: Incompatible stack types: I4 vs O
			//IL_0ab3->IL04f8: Incompatible stack types: I4 vs O
			//IL_08e1->IL04f8: Incompatible stack types: I4 vs O
			//IL_06e2->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b62->IL04f8: Incompatible stack types: I4 vs O
			//IL_0c6b->IL04f8: Incompatible stack types: I4 vs O
			//IL_08f8->IL04f8: Incompatible stack types: I4 vs O
			//IL_0bcd->IL04f8: Incompatible stack types: I4 vs O
			//IL_0673->IL04f8: Incompatible stack types: I4 vs O
			//IL_080e->IL04f8: Incompatible stack types: I4 vs O
			//IL_097e->IL04f8: Incompatible stack types: I4 vs O
			//IL_0cc6->IL04f8: Incompatible stack types: I4 vs O
			//IL_0955->IL04f8: Incompatible stack types: I4 vs O
			//IL_0789->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a10->IL04f8: Incompatible stack types: I4 vs O
			//IL_0837->IL04f8: Incompatible stack types: I4 vs O
			//IL_0a63->IL04f8: Incompatible stack types: I4 vs O
			//IL_0ba7->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b45->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b78->IL04f8: Incompatible stack types: I4 vs O
			//IL_09aa->IL04f8: Incompatible stack types: I4 vs O
			//IL_0bd8->IL04f8: Incompatible stack types: I4 vs O
			//IL_0c07->IL04f8: Incompatible stack types: I4 vs O
			//IL_0cd1->IL04f8: Incompatible stack types: I4 vs O
			//IL_0da0->IL04f8: Incompatible stack types: I4 vs O
			//IL_0ca0->IL04f8: Incompatible stack types: I4 vs O
			//IL_0879->IL04f8: Incompatible stack types: I4 vs O
			//IL_0b50->IL04f8: Incompatible stack types: I4 vs O
			//IL_0884->IL04f8: Incompatible stack types: I4 vs O
			int num = 4;
			object result2 = default(object);
			dynamic obj3 = default(object);
			object obj30 = default(object);
			object obj12 = default(object);
			object sourceDirectory = default(object);
			dynamic obj6 = default(object);
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj7 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			object result = default(object);
			object obj10 = default(object);
			object obj11 = default(object);
			object obj9 = default(object);
			object obj8 = default(object);
			object obj13 = default(object);
			object obj25 = default(object);
			object obj22 = default(object);
			object obj24 = default(object);
			object obj27 = default(object);
			object obj29 = default(object);
			object obj33 = default(object);
			while (true)
			{
				object obj = num;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							if ((nint)obj != 14)
							{
								if ((nint)obj == 995)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							__t__builder.SetResult((McpBuildResult)result2);
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4abb095abaf846009b4cca8873b94957 == 0)
							{
								obj2 = 0;
							}
							continue;
						case 6:
							_outputPath_5__2 = null;
							num = 7;
							break;
						case 0:
							return;
						case 3:
							try
							{
								object obj4;
								if ((nuint)(nint)obj3 <= (nuint)1u)
								{
									obj4 = 6;
									goto IL_00b9;
								}
								goto IL_04bf;
								IL_04bf:
								ValidateOptions(options);
								obj4 = 10;
								goto IL_00b9;
								IL_00b9:
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										if ((nint)obj30 != 22)
										{
											if ((nint)obj30 == 1002)
											{
												goto IL_00b5;
											}
											goto case 6;
										}
										_outputPath_5__2 = System.IO.Path.GetFullPath(options.OutputPath);
										obj4 = 15;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_916ae56933ff4374af011c79e3cb023a != 0)
										{
											obj4 = 0;
										}
										continue;
									case 6:
									case 12:
										obj4 = 5;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a1a3680c38d4488598afb1defd71e635 != 0)
										{
											obj4 = 10;
										}
										continue;
									case 8:
										_helperDirectory_5__4 = PublishedFileResolver.ResolveDirectory("Features/McpStudio/Builder/PackageTool");
										obj4 = 3;
										continue;
									case 9:
									{
										string text3 = _outputPath_5__2;
										string text4 = ".build-";
										System.Guid obj31 = System.Guid.NewGuid();
										_temporaryOutputPath_5__3 = string.Concat(text3, text4, (obj31).ToString("N"), ".tmp");
										obj4 = 14;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_384fbdc0d71943e1a4f9f50f53afad51 != 0)
										{
											obj4 = 7;
										}
										continue;
									}
									case 14:
										obj12 = PublishedFileResolver.Resolve("Features/McpStudio/Builder/compile_sources.py");
										obj4 = 8;
										continue;
									case 10:
									{
										sourceDirectory = System.IO.Path.GetFullPath(options.SourceDirectory);
										int num3 = 22;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 == 0)
										{
											num3 = 16;
										}
										obj30 = num3;
										goto IL_00b5;
									}
									case 0:
										if (System.IO.File.Exists(_outputPath_5__2))
										{
											obj4 = 11;
											continue;
										}
										System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(_outputPath_5__2));
										obj4 = 9;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8a5abf847bb54a3aa56e2df86c0b5690 != 0)
										{
											obj4 = 4;
										}
										continue;
									case 2:
										System.IO.Directory.CreateDirectory(_temporaryDirectory_5__5);
										obj4 = 12;
										continue;
									case 13:
										throw new FileNotFoundException("缺少 Python 编译脚本", (string)obj12);
									case 11:
										throw new IOException("输出文件已存在，请选择其他路径；构建器不会覆盖已有 MCP 文件");
									case 4:
										throw new DirectoryNotFoundException(string.Concat("缺少 MCP 打包工具目录：", _helperDirectory_5__4));
									case 1:
									{
										string text = System.IO.Path.GetTempPath();
										string text2 = "chronal-mcp-";
										System.Guid obj31 = System.Guid.NewGuid();
										_temporaryDirectory_5__5 = System.IO.Path.Combine(text, string.Concat(text2, (obj31).ToString("N")));
										obj4 = 2;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f != 0)
										{
											obj4 = 14;
										}
										continue;
									}
									case 3:
										if (System.IO.File.Exists((string)obj12))
										{
											if (System.IO.Directory.Exists(_helperDirectory_5__4))
											{
												obj4 = 1;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
												{
													obj4 = 8;
												}
												continue;
											}
											goto case 4;
										}
										obj4 = 13;
										continue;
									case 7:
										break;
									case 5:
										{
											try
											{
												object obj5;
												if (obj3 != null)
												{
													obj5 = 18;
													goto IL_04f8;
												}
												goto IL_0789;
												IL_0789:
												obj6 = __u__1;
												int num2 = 52;
												goto IL_04f0;
												IL_04f8:
												while (true)
												{
													switch ((int)obj5)
													{
													case 3:
														return;
													case 17:
														return;
													case 10:
													case 29:
														ValidateSource((string)sourceDirectory, options.PackageId, options.EntryModule);
														obj5 = 6;
														continue;
													case 8:
														goto end_IL_04f8;
													case 42:
														goto IL_0630;
													case 24:
														((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj7))->AppendFormatted<int>(((McpPythonCompiler.ProcessResult*)(&result))->ExitCode);
														obj5 = 15;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 != 0)
														{
															obj5 = 9;
														}
														continue;
													case 9:
														obj7 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(16, 2);
														obj5 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_84adde53dc7e4a5fa7522d701cb0013d == 0)
														{
															obj5 = 8;
														}
														continue;
													case 15:
														goto IL_069c;
													case 7:
														(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj7)).AppendFormatted(TrimOutput(((McpPythonCompiler.ProcessResult*)(&result))->Output), (string)null);
														obj5 = 25;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
														{
															obj5 = 9;
														}
														continue;
													case 34:
													case 40:
														obj10 = RunPackageToolAsync(_helperDirectory_5__4, _temporaryDirectory_5__5, _temporaryOutputPath_5__3, options.PackageId, options.EntryModule, options.PackageToolPath, options.GoPath, cancellationToken).ConfigureAwait(false);
														obj5 = 31;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f7bdf7cbba314aacbe28a6672ff5f582 != 0)
														{
															obj5 = 46;
														}
														continue;
													case 27:
														goto IL_0789;
													case 12:
													case 26:
														result2 = (object)new McpBuildResult
														{
															OutputPath = _outputPath_5__2,
															SizeBytes = ((McpPackageValidator.McpPackageInfo*)(&obj11))->SizeBytes,
															Sha256 = ((McpPackageValidator.McpPackageInfo*)(&obj11))->Sha256,
															EntryCount = ((McpPackageValidator.McpPackageInfo*)(&obj11))->EntryCount,
															EntryModule = ((McpPackageValidator.McpPackageInfo*)(&obj11))->EntryModule,
															BuildLog = ((McpPythonCompiler.ProcessResult*)(&result))->Output
														};
														obj5 = 19;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 != 0)
														{
															obj5 = 37;
														}
														continue;
													case 38:
														obj3 = -1;
														__1__state = -1;
														obj5 = 36;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5616e31a21b646f69463de8959779c49 == 0)
														{
															obj5 = 34;
														}
														continue;
													case 25:
														throw new InvalidOperationException((*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj7)).ToStringAndClear());
													case 2:
														if (!((ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter*)(&obj6))->IsCompleted)
														{
															obj5 = 28;
															continue;
														}
														goto case 30;
													case 0:
													case 14:
														obj9 = McpPythonCompiler.CompileAsync(options.PythonPath, (string)obj12, (string)sourceDirectory, _temporaryDirectory_5__5, cancellationToken).ConfigureAwait(false);
														obj5 = 39;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ff96c054b9a547fc83bea3daf4a435ff == 0)
														{
															obj5 = 36;
														}
														continue;
													case 20:
														goto IL_08e1;
													case 37:
														obj3 = -1;
														__1__state = -1;
														obj5 = 30;
														continue;
													case 33:
														if (((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj8))->IsCompleted)
														{
															obj5 = 5;
															continue;
														}
														goto case 11;
													case 28:
														obj3 = 0;
														__1__state = 0;
														obj5 = 43;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 != 0)
														{
															obj5 = 10;
														}
														continue;
													case 6:
														goto IL_097e;
													case 21:
														__u__2 = (ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter)obj8;
														obj5 = 16;
														continue;
													case 43:
														__u__1 = (ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter)obj6;
														obj5 = 13;
														continue;
													case 22:
													case 35:
														obj11 = McpPackageValidator.Validate(_temporaryOutputPath_5__3, options.PackageId, options.EntryModule);
														obj5 = 7;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf != 0)
														{
															obj5 = 41;
														}
														continue;
													case 31:
														obj8 = ((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>*)(&obj10))->GetAwaiter();
														obj5 = 33;
														continue;
													case 16:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter, _BuildAsync_d__3>(ref *(ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj8), ref this);
														obj5 = 17;
														continue;
													case 39:
														obj6 = ((ConfiguredTaskAwaitable<string>*)(&obj9))->GetAwaiter();
														obj5 = 22;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f != 0)
														{
															obj5 = 2;
														}
														continue;
													case 1:
														obj8 = __u__2;
														obj5 = 12;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 == 0)
														{
															obj5 = 42;
														}
														continue;
													case 11:
														obj3 = 1;
														__1__state = 1;
														obj5 = 21;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3a9f60458a5840868f1b224a8d25b071 == 0)
														{
															obj5 = 47;
														}
														continue;
													case 4:
														System.IO.File.Move(_temporaryOutputPath_5__3, _outputPath_5__2);
														obj5 = 14;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_495680ddee4b4d2499de9ae6f49aa33c == 0)
														{
															obj5 = 32;
														}
														continue;
													case 13:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _BuildAsync_d__3>(ref *(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter*)(&obj6), ref this);
														obj5 = 3;
														continue;
													case 30:
														((ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter*)(&obj6))->GetResult();
														obj5 = 20;
														continue;
													case 5:
													case 36:
														result = ((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj8))->GetResult();
														obj5 = 44;
														continue;
													case 44:
														goto IL_0b25;
													case 18:
														if ((nint)obj3 != 1)
														{
															obj5 = 23;
															continue;
														}
														goto case 1;
													case 41:
														(cancellationToken).ThrowIfCancellationRequested();
														obj5 = 39;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 != 0)
														{
															obj5 = 4;
														}
														continue;
													case 23:
														goto IL_0ba7;
													case 32:
														goto IL_0ca0;
													case 19:
														goto end_IL_04d5;
													}
													if ((nint)obj13 != 52)
													{
														if ((nint)obj13 == 1032)
														{
															goto IL_04f4;
														}
														goto IL_069c;
													}
													__u__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
													obj5 = 37;
													continue;
													IL_0ca0:
													IProgress<string> obj14 = progress;
													if (obj14 == null)
													{
														obj5 = 4;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a != 0)
														{
															obj5 = 12;
														}
														continue;
													}
													global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler obj15 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(22, 3);
													(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15)).AppendLiteral("验证完成：");
													((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15))->AppendFormatted<int>(((McpPackageValidator.McpPackageInfo*)(&obj11))->EntryCount);
													(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15)).AppendLiteral(" 个条目，");
													((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15))->AppendFormatted<long>(((McpPackageValidator.McpPackageInfo*)(&obj11))->SizeBytes);
													(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15)).AppendLiteral(" 字节，SHA-256 ");
													(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15)).AppendFormatted(((McpPackageValidator.McpPackageInfo*)(&obj11))->Sha256);
													obj14.Report((*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj15)).ToStringAndClear());
													obj5 = 26;
													continue;
													IL_097e:
													IProgress<string> obj16 = progress;
													if (obj16 == null)
													{
														obj5 = 18;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f651726544964479b0083c2c6dbce1d1 == 0)
														{
															obj5 = 0;
														}
													}
													else
													{
														obj16.Report("阶段 2/4：使用 Python 2.7 编译源码");
														obj5 = 14;
													}
													continue;
													IL_08e1:
													IProgress<string> obj17 = progress;
													if (obj17 == null)
													{
														obj5 = 40;
														continue;
													}
													obj17.Report("阶段 3/4：生成 MCPK 容器");
													obj5 = 34;
													continue;
													IL_0b25:
													if (((McpPythonCompiler.ProcessResult*)(&result))->ExitCode == 0)
													{
														IProgress<string> obj18 = progress;
														if (obj18 == null)
														{
															obj5 = 42;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 != 0)
															{
																obj5 = 22;
															}
														}
														else
														{
															obj18.Report("阶段 4/4：回读验证与 SHA-256 校验");
															obj5 = 35;
														}
													}
													else
													{
														obj5 = 51;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb == 0)
														{
															obj5 = 9;
														}
													}
													continue;
													IL_0ba7:
													IProgress<string> obj19 = progress;
													if (obj19 == null)
													{
														obj5 = 0;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3d9d86761de84aa48245c594db282bdf != 0)
														{
															obj5 = 29;
														}
													}
													else
													{
														obj19.Report("阶段 1/4：检查源码与入口");
														obj5 = 10;
													}
													continue;
													IL_069c:
													(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj7)).AppendLiteral("）：");
													obj5 = 0;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 == 0)
													{
														obj5 = 7;
													}
													continue;
													end_IL_04f8:
													break;
												}
												(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj7)).AppendLiteral("MCPK 打包失败（退出码 ");
												num2 = 24;
												goto IL_04f0;
												IL_04f0:
												obj13 = num2;
												goto IL_04f4;
												IL_04f4:
												obj5 = obj13;
												goto IL_04f8;
												IL_0630:
												__u__2 = default(ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter);
												num2 = 38;
												goto IL_04f0;
												end_IL_04d5:;
											}
											finally
											{
												if ((nint)obj3 < 0)
												{
													object obj20 = 0;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 == 0)
													{
														obj20 = 0;
													}
													while (true)
													{
														switch ((int)obj20)
														{
														default:
															if ((nint)obj25 == 991)
															{
																obj20 = obj25;
																continue;
															}
															goto case 0;
														case 1:
															try
															{
																object obj21;
																if (!System.IO.File.Exists(_temporaryOutputPath_5__3))
																{
																	obj21 = 5;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9eef6557bd0f4e9cabe58f018cd42055 == 0)
																	{
																		obj21 = 0;
																	}
																	goto IL_0e4d;
																}
																goto IL_0e71;
																IL_0e4d:
																while (true)
																{
																	switch ((int)obj21)
																	{
																	default:
																		if ((nint)obj22 == 990)
																		{
																			goto IL_0e49;
																		}
																		goto end_IL_0e4d;
																	case 2:
																		break;
																	case 0:
																		goto end_IL_0e4d;
																	case 1:
																		goto end_IL_0e4d;
																	}
																	goto IL_0e71;
																	IL_0e49:
																	obj21 = obj22;
																	continue;
																	end_IL_0e4d:
																	break;
																}
																goto end_IL_0e07;
																IL_0e71:
																System.IO.File.Delete(_temporaryOutputPath_5__3);
																obj21 = 1;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 != 0)
																{
																	obj21 = 3;
																}
																goto IL_0e4d;
																end_IL_0e07:;
															}
															catch (global::System.Exception)
															{
																object obj23 = 5;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_31a06ac266364bee8fef51fc97395192 != 0)
																{
																	obj23 = 0;
																}
																while (true)
																{
																	switch ((int)obj23)
																	{
																	default:
																		if ((nint)obj24 == 988)
																		{
																			obj23 = obj24;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															goto end_IL_0dde;
														case 2:
															break;
														case 0:
															try
															{
																if (!System.IO.Directory.Exists(_temporaryDirectory_5__5))
																{
																	break;
																}
																object obj26 = 0;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6883c26806134cb3b7f5e7b631c19374 != 0)
																{
																	obj26 = 4;
																}
																while (true)
																{
																	switch ((int)obj26)
																	{
																	default:
																		if ((nint)obj27 == 989)
																		{
																			obj26 = obj27;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	case 1:
																		goto end_IL_0f78;
																	}
																	System.IO.Directory.Delete(_temporaryDirectory_5__5, true);
																	obj26 = 7;
																	if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd == 0)
																	{
																		obj26 = 1;
																	}
																	continue;
																	end_IL_0f78:
																	break;
																}
															}
															catch (global::System.Exception)
															{
																object obj28 = 0;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 == 0)
																{
																	obj28 = 3;
																}
																while (true)
																{
																	switch ((int)obj28)
																	{
																	default:
																		if ((nint)obj29 == 988)
																		{
																			obj28 = obj29;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															break;
														case 3:
															goto end_IL_0dde;
														}
														obj20 = 1;
														if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_fd6fdaa7d4824d4c9cf1c9399aa7f204 != 0)
														{
															obj20 = 2;
														}
														continue;
														end_IL_0dde:
														break;
													}
												}
											}
											goto end_IL_00b9;
										}
										IL_00b5:
										obj4 = obj30;
										continue;
									}
									goto IL_04bf;
									continue;
									end_IL_00b9:
									break;
								}
							}
							catch (global::System.Exception exception)
							{
								object obj32 = 2;
								while (true)
								{
									int num4;
									switch ((int)obj32)
									{
									case 1:
										return;
									default:
										if ((nint)obj33 != 13)
										{
											if ((nint)obj33 == 993)
											{
												goto IL_105a;
											}
											goto case 2;
										}
										_temporaryDirectory_5__5 = null;
										num4 = 3;
										goto IL_1056;
									case 3:
										__t__builder.SetException(exception);
										num4 = 1;
										goto IL_1056;
									case 4:
										_helperDirectory_5__4 = null;
										num4 = 13;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4abb095abaf846009b4cca8873b94957 != 0)
										{
											num4 = 8;
										}
										goto IL_1056;
									case 2:
										__1__state = -2;
										obj32 = 12;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8cd7f54b623a4d42b1a5e008c75a22ed != 0)
										{
											obj32 = 5;
										}
										break;
									case 0:
										_temporaryOutputPath_5__3 = null;
										obj32 = 4;
										break;
									case 5:
										{
											_outputPath_5__2 = null;
											obj32 = 0;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
											{
												obj32 = 5;
											}
											break;
										}
										IL_105a:
										obj32 = obj33;
										break;
										IL_1056:
										obj33 = num4;
										goto IL_105a;
									}
								}
							}
							goto case 5;
						case 5:
							__1__state = -2;
							num = 6;
							break;
						case 4:
							obj3 = __1__state;
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 != 0)
							{
								obj2 = 13;
							}
							continue;
						case 1:
							_temporaryDirectory_5__5 = null;
							num = 14;
							break;
						case 7:
							_temporaryOutputPath_5__3 = null;
							obj2 = 2;
							continue;
						case 2:
							_helperDirectory_5__4 = null;
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 != 0)
							{
								obj2 = 1;
							}
							continue;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0050->IL0010: Incompatible stack types: I4 vs O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						__t__builder.SetStateMachine(stateMachine);
						obj2 = 3;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool gVIdc5L23PrSCewDKWdo()
		{
			return bei3etL21roCSUon4RMu == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object B9yofAL2vGyLmjK2ilJe()
		{
			return bei3etL21roCSUon4RMu;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RunPackageToolAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<McpPythonCompiler.ProcessResult> __t__builder;

		public string packageToolPath;

		public string helperDirectory;

		public string compiledDirectory;

		public string outputPath;

		public string packageId;

		public string entryModule;

		public CancellationToken cancellationToken;

		public string goPath;

		private ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter __u__1;

		private static object Iq1nWdL2Epj5YslCR5tX;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_0789: Expected I4, but got O
			//IL_007b: Expected O, but got I4
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Expected O, but got Unknown
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Expected O, but got Unknown
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Expected O, but got I4
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Expected O, but got I4
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected O, but got I4
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			//IL_03bc: Expected O, but got I4
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a7: Expected O, but got Unknown
			//IL_0724: Unknown result type (might be due to invalid IL or missing references)
			//IL_072f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I4
			//IL_0159: Expected I4, but got O
			//IL_075b->IL0778: Incompatible stack types: I4 vs O
			//IL_0766->IL0778: Incompatible stack types: I4 vs O
			//IL_07ae->IL0778: Incompatible stack types: I4 vs O
			//IL_07cf->IL0778: Incompatible stack types: I4 vs O
			//IL_07da->IL0778: Incompatible stack types: I4 vs O
			//IL_0085->IL0010: Incompatible stack types: I4 vs O
			//IL_00a1->IL0010: Incompatible stack types: I4 vs O
			//IL_00ac->IL0010: Incompatible stack types: I4 vs O
			//IL_00be->IL00d0: Incompatible stack types: I4 vs O
			//IL_0418->IL00d0: Incompatible stack types: I4 vs O
			//IL_037c->IL00d0: Incompatible stack types: I4 vs O
			//IL_0423->IL00d0: Incompatible stack types: I4 vs O
			//IL_0387->IL00d0: Incompatible stack types: I4 vs O
			//IL_054c->IL00d0: Incompatible stack types: I4 vs O
			//IL_01bb->IL00d0: Incompatible stack types: I4 vs O
			//IL_058f->IL00d0: Incompatible stack types: I4 vs O
			//IL_018d->IL00d0: Incompatible stack types: I4 vs O
			//IL_05d8->IL00d0: Incompatible stack types: I4 vs O
			//IL_0360->IL00d0: Incompatible stack types: I4 vs O
			//IL_0309->IL00d0: Incompatible stack types: I4 vs O
			//IL_02f6->IL00d0: Incompatible stack types: I4 vs O
			//IL_0348->IL00d0: Incompatible stack types: I4 vs O
			//IL_03dd->IL00d0: Incompatible stack types: I4 vs O
			//IL_01cd->IL00d0: Incompatible stack types: I4 vs O
			//IL_03cb->IL00d0: Incompatible stack types: I4 vs O
			//IL_05bb->IL00d0: Incompatible stack types: I4 vs O
			//IL_0557->IL00d0: Incompatible stack types: I4 vs O
			//IL_060f->IL00d0: Incompatible stack types: I4 vs O
			//IL_02b3->IL00d0: Incompatible stack types: I4 vs O
			//IL_03ac->IL00d0: Incompatible stack types: I4 vs O
			//IL_0740->IL00d0: Incompatible stack types: I4 vs O
			//IL_0329->IL00d0: Incompatible stack types: I4 vs O
			//IL_0257->IL00d0: Incompatible stack types: I4 vs O
			//IL_022e->IL00d0: Incompatible stack types: I4 vs O
			//IL_05c6->IL00d0: Incompatible stack types: I4 vs O
			//IL_02be->IL00d0: Incompatible stack types: I4 vs O
			//IL_03b7->IL00d0: Incompatible stack types: I4 vs O
			//IL_0334->IL00d0: Incompatible stack types: I4 vs O
			//IL_0262->IL00d0: Incompatible stack types: I4 vs O
			int num = 2;
			dynamic obj3 = default(object);
			dynamic obj7 = default(object);
			dynamic obj5 = default(object);
			dynamic obj6 = default(object);
			object result = default(object);
			object obj8 = default(object);
			object obj10 = default(object);
			while (true)
			{
				object obj = num;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							if ((nint)obj != 10)
							{
								if ((nint)obj == 991)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							return;
						case 0:
							break;
						case 2:
							obj3 = __1__state;
							obj2 = 1;
							continue;
						case 3:
							__1__state = -2;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2ea097de099140f192d12c8111241f4e == 0)
							{
								obj2 = 1;
							}
							continue;
						case 1:
							try
							{
								object obj4;
								if (obj3 == null)
								{
									obj4 = 3;
									goto IL_00d0;
								}
								goto IL_0360;
								IL_0360:
								if ((nint)obj3 != 1)
								{
									obj4 = 10;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_13568c2ecd3e40679d0e8ed63093dad4 != 0)
									{
										obj4 = 37;
									}
									goto IL_00d0;
								}
								goto IL_03fc;
								IL_00d0:
								while (true)
								{
									int num2;
									string executable;
									string text;
									switch ((int)obj4)
									{
									case 16:
										return;
									case 25:
										return;
									default:
										if ((nint)obj7 != 40)
										{
											if ((nint)obj7 == 1020)
											{
												goto IL_00cc;
											}
											goto case 4;
										}
										goto end_IL_00ad;
									case 6:
										obj5 = ((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>*)(&obj6))->GetAwaiter();
										obj4 = 31;
										continue;
									case 30:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter, _RunPackageToolAsync_d__4>(ref *(ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj5), ref this);
										num2 = 25;
										goto IL_00c8;
									case 1:
										__u__1 = default(ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter);
										obj4 = 22;
										continue;
									case 3:
									case 26:
										obj5 = __u__1;
										obj4 = 19;
										continue;
									case 14:
										executable = goPath;
										goto IL_062a;
									case 23:
										executable = "go";
										goto IL_062a;
									case 19:
										__u__1 = default(ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter);
										num2 = 5;
										goto IL_00c8;
									case 31:
										if (!((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj5))->IsCompleted)
										{
											obj4 = 13;
											continue;
										}
										goto case 9;
									case 12:
									case 28:
										if (!string.IsNullOrWhiteSpace(goPath))
										{
											obj4 = 28;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
											{
												obj4 = 14;
											}
											continue;
										}
										if (System.OperatingSystem.IsWindows())
										{
											num2 = 27;
											goto IL_00c8;
										}
										goto case 23;
									case 10:
										if (!string.IsNullOrWhiteSpace(packageToolPath))
										{
											obj4 = 2;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_29300ae0ec1d42aeac4a5187ea9fcbba != 0)
											{
												obj4 = 24;
											}
											continue;
										}
										text = System.IO.Path.Combine(helperDirectory, "mcp-package-tool.exe");
										goto IL_0603;
									case 13:
										obj3 = 0;
										__1__state = 0;
										obj4 = 24;
										continue;
									case 9:
										result = ((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj5))->GetResult();
										obj4 = 17;
										continue;
									case 21:
										if (((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj5))->IsCompleted)
										{
											obj4 = 4;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf == 0)
											{
												obj4 = 38;
											}
											continue;
										}
										goto case 29;
									case 22:
										obj3 = -1;
										__1__state = -1;
										obj4 = 20;
										continue;
									case 8:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter, _RunPackageToolAsync_d__4>(ref *(ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj5), ref this);
										obj4 = 16;
										continue;
									case 15:
										break;
									case 11:
										if (!System.IO.File.Exists((string)obj8))
										{
											obj4 = 12;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9eef6557bd0f4e9cabe58f018cd42055 != 0)
											{
												obj4 = 30;
											}
											continue;
										}
										goto case 0;
									case 29:
										obj3 = 1;
										__1__state = 1;
										obj4 = 7;
										continue;
									case 24:
										__u__1 = (ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter)obj5;
										obj4 = 30;
										continue;
									case 2:
										text = packageToolPath;
										goto IL_0603;
									case 18:
										goto IL_03fc;
									case 4:
									case 20:
										result = ((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter*)(&obj5))->GetResult();
										num2 = 40;
										goto IL_00c8;
									case 0:
										obj6 = McpPythonCompiler.RunAsync((string)obj8, new string[8]
										{
											"--compiled-source-dir",
											compiledDirectory,
											"--output",
											outputPath,
											"--package-id",
											packageId,
											"--entry-module",
											entryModule
										}, helperDirectory, cancellationToken).ConfigureAwait(false);
										obj4 = 6;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5abcb08dd0ae4b88988bbb89131b0cab == 0)
										{
											obj4 = 31;
										}
										continue;
									case 5:
										obj3 = -1;
										__1__state = -1;
										obj4 = 9;
										continue;
									case 17:
										goto end_IL_00ad;
									case 32:
										obj5 = ((ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>*)(&obj6))->GetAwaiter();
										obj4 = 21;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab != 0)
										{
											obj4 = 18;
										}
										continue;
									case 7:
										__u__1 = (ConfiguredTaskAwaitable<McpPythonCompiler.ProcessResult>.ConfiguredTaskAwaiter)obj5;
										obj4 = 8;
										continue;
									case 27:
										{
											executable = "go.exe";
											goto IL_062a;
										}
										IL_00c8:
										obj7 = num2;
										goto IL_00cc;
										IL_062a:
										obj6 = McpPythonCompiler.RunAsync(executable, new string[10]
										{
											"run",
											".",
											"--compiled-source-dir",
											compiledDirectory,
											"--output",
											outputPath,
											"--package-id",
											packageId,
											"--entry-module",
											entryModule
										}, helperDirectory, cancellationToken).ConfigureAwait(false);
										obj4 = 32;
										continue;
										IL_0603:
										obj8 = text;
										obj4 = 11;
										continue;
										IL_00cc:
										obj4 = obj7;
										continue;
									}
									break;
								}
								goto IL_0360;
								IL_03fc:
								obj5 = __u__1;
								obj4 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f7bdf7cbba314aacbe28a6672ff5f582 == 0)
								{
									obj4 = 1;
								}
								goto IL_00d0;
								end_IL_00ad:;
							}
							catch (global::System.Exception exception)
							{
								object obj9 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 != 0)
								{
									obj9 = 0;
								}
								while (true)
								{
									switch ((int)obj9)
									{
									case 1:
										return;
									default:
										if ((nint)obj10 == 990)
										{
											obj9 = obj10;
											break;
										}
										goto case 0;
									case 0:
										__1__state = -2;
										obj9 = 2;
										break;
									case 2:
										__t__builder.SetException(exception);
										obj9 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_09be964badeb4066912116bbb7cb20e9 == 0)
										{
											obj9 = 4;
										}
										break;
									}
								}
							}
							goto case 3;
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
				__t__builder.SetResult((McpPythonCompiler.ProcessResult)result);
				num = 10;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_0050->IL0010: Incompatible stack types: I4 vs O
			//IL_005b->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						__t__builder.SetStateMachine(stateMachine);
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd86dbd500ab43b1bb4264e56ddd52b4 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KRY0cIL227kAifyZmLAy()
		{
			return Iq1nWdL2Epj5YslCR5tX == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object sWbFcVL2qbmOfMFyPLp5()
		{
			return Iq1nWdL2Epj5YslCR5tX;
		}
	}

	private static Regex Identifier;

	private static Regex EntryPattern;

	private const long MaxSourceBytes = 52428800L;

	internal static McpBuilderService GBROMYLvuwR4pfPtnNnG;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<McpBuildResult> BuildAsync(McpBuildOptions options, IProgress<string>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7->IL0010: Incompatible stack types: I4 vs O
		//IL_00e3->IL0010: Incompatible stack types: I4 vs O
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		//IL_0064->IL0010: Incompatible stack types: I4 vs O
		//IL_00ee->IL0010: Incompatible stack types: I4 vs O
		//IL_00a4->IL0010: Incompatible stack types: I4 vs O
		//IL_00af->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
		dynamic obj3 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						((dynamic)obj3).__1__state = -1;
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<McpBuildResult>.Create();
						obj2 = 3;
						continue;
					case 0:
						break;
					case 3:
						((dynamic)obj3).options = options;
						obj2 = 2;
						continue;
					case 1:
						((dynamic)obj3).__t__builder.Start<_BuildAsync_d__3>(ref obj3);
						obj2 = 5;
						continue;
					case 2:
						((dynamic)obj3).progress = progress;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a39b60a5f46a44329f1ae7a5ef50ae96 == 0)
						{
							obj2 = 8;
						}
						continue;
					case 5:
						return ((dynamic)obj3).__t__builder.Task;
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
			((dynamic)obj3).cancellationToken = cancellationToken;
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<McpPythonCompiler.ProcessResult> RunPackageToolAsync(string helperDirectory, string compiledDirectory, string outputPath, string packageId, string entryModule, string packageToolPath, string goPath, CancellationToken cancellationToken)
	{
		//IL_000c: Expected O, but got I4
		//IL_0041: Expected I4, but got O
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0->IL0010: Incompatible stack types: I4 vs O
		//IL_01ac->IL0010: Incompatible stack types: I4 vs O
		//IL_019a->IL0010: Incompatible stack types: I4 vs O
		//IL_0125->IL0010: Incompatible stack types: I4 vs O
		//IL_00b9->IL0010: Incompatible stack types: I4 vs O
		//IL_0184->IL0010: Incompatible stack types: I4 vs O
		//IL_0091->IL0010: Incompatible stack types: I4 vs O
		//IL_00eb->IL0010: Incompatible stack types: I4 vs O
		//IL_00c4->IL0010: Incompatible stack types: I4 vs O
		//IL_009c->IL0010: Incompatible stack types: I4 vs O
		//IL_0108->IL0010: Incompatible stack types: I4 vs O
		//IL_0113->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
		dynamic obj3 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 17)
						{
							if ((nint)obj == 998)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						((dynamic)obj3).cancellationToken = cancellationToken;
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_28a8309f77124973ab9263f59df1f564 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 0:
						return ((dynamic)obj3).__t__builder.Task;
					case 10:
						((dynamic)obj3).__t__builder.Start<_RunPackageToolAsync_d__4>(ref obj3);
						obj2 = 8;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_495680ddee4b4d2499de9ae6f49aa33c == 0)
						{
							obj2 = 0;
						}
						continue;
					case 7:
						((dynamic)obj3).packageToolPath = packageToolPath;
						obj2 = 14;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 1:
						((dynamic)obj3).__1__state = -1;
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf == 0)
						{
							obj2 = 16;
						}
						continue;
					case 6:
						((dynamic)obj3).packageId = packageId;
						obj2 = 8;
						continue;
					case 5:
						((dynamic)obj3).outputPath = outputPath;
						num = 6;
						break;
					case 9:
						((dynamic)obj3).compiledDirectory = compiledDirectory;
						num = 5;
						break;
					case 2:
						((dynamic)obj3).goPath = goPath;
						num = 17;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7648938319564190ac26c6ec3b0a6621 == 0)
						{
							num = 16;
						}
						break;
					case 8:
						((dynamic)obj3).entryModule = entryModule;
						obj2 = 7;
						continue;
					case 4:
						((dynamic)obj3).__t__builder = AsyncTaskMethodBuilder<McpPythonCompiler.ProcessResult>.Create();
						obj2 = 3;
						continue;
					case 3:
						((dynamic)obj3).helperDirectory = helperDirectory;
						obj2 = 9;
						continue;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateOptions(McpBuildOptions options)
	{
		//IL_000c: Expected O, but got I4
		//IL_003d: Expected I4, but got O
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224->IL0010: Incompatible stack types: I4 vs O
		//IL_023f->IL0010: Incompatible stack types: I4 vs O
		//IL_02c8->IL0010: Incompatible stack types: I4 vs O
		//IL_00b9->IL0010: Incompatible stack types: I4 vs O
		//IL_0294->IL0010: Incompatible stack types: I4 vs O
		//IL_01e9->IL0010: Incompatible stack types: I4 vs O
		//IL_02d3->IL0010: Incompatible stack types: I4 vs O
		//IL_011a->IL0010: Incompatible stack types: I4 vs O
		//IL_029f->IL0010: Incompatible stack types: I4 vs O
		//IL_0351->IL0010: Incompatible stack types: I4 vs O
		//IL_01f4->IL0010: Incompatible stack types: I4 vs O
		//IL_035c->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
		dynamic obj3 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 16)
						{
							if ((nint)obj == 997)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						goto IL_02d3;
					case 7:
						if (!string.Equals(((((dynamic)obj3).Groups).Item).Value, options.PackageId, (StringComparison)4))
						{
							obj2 = 3;
							break;
						}
						if (!string.IsNullOrWhiteSpace(options.OutputPath))
						{
							obj2 = 8;
							break;
						}
						goto case 1;
					case 3:
					case 9:
						throw new ArgumentException("入口必须是 <包ID>.modMain", "options");
					case 0:
						if ((options.PackageId).Length <= 32)
						{
							obj3 = (EntryPattern).Match(options.EntryModule ?? string.Empty);
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_384fbdc0d71943e1a4f9f50f53afad51 != 0)
							{
								obj2 = 16;
							}
							break;
						}
						goto end_IL_000c;
					case 1:
						throw new ArgumentException("输出文件必须使用 .mcp 扩展名", "options");
					case 6:
						throw new DirectoryNotFoundException(string.Concat("源码目录不存在：", options.SourceDirectory));
					case 5:
						System.ArgumentNullException.ThrowIfNull(options, "options");
						obj2 = 4;
						break;
					case 2:
						if (!((dynamic)obj3).Success)
						{
							obj2 = 9;
							break;
						}
						goto case 7;
					case 8:
						if (string.Equals(System.IO.Path.GetExtension(options.OutputPath), ".mcp", (StringComparison)5))
						{
							return;
						}
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b18c9101a9694aa1aae5a0a4ca0f1892 == 0)
						{
							obj2 = 1;
						}
						break;
					case 4:
						{
							if (System.IO.Directory.Exists(options.SourceDirectory))
							{
								if ((Identifier).IsMatch(options.PackageId))
								{
									obj2 = 10;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b7393eff3b9049068ae7c92e2e0229a5 == 0)
									{
										obj2 = 0;
									}
									break;
								}
								goto IL_02d3;
							}
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f != 0)
							{
								obj2 = 6;
							}
							break;
						}
						IL_02d3:
						throw new ArgumentException("包 ID 只能包含 ASCII 字母、数字和下划线，长度不超过 32", "options");
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 16;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateSource(string sourceDirectory, string packageId, string entryModule)
	{
		//IL_000c: Expected O, but got I4
		//IL_0055: Expected I4, but got O
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got I8
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197->IL0010: Incompatible stack types: I4 vs O
		//IL_02ca->IL0010: Incompatible stack types: I4 vs O
		//IL_016d->IL0010: Incompatible stack types: I4 vs O
		//IL_02a8->IL0010: Incompatible stack types: I4 vs O
		//IL_01a2->IL0010: Incompatible stack types: I4 vs O
		//IL_00db->IL0010: Incompatible stack types: I4 vs O
		//IL_02d5->IL0010: Incompatible stack types: I4 vs O
		//IL_0117->IL0010: Incompatible stack types: I4 vs O
		//IL_01f0->IL0010: Incompatible stack types: I4 vs O
		//IL_01ce->IL0010: Incompatible stack types: I4 vs O
		//IL_02b3->IL0010: Incompatible stack types: I4 vs O
		//IL_00a5->IL0010: Incompatible stack types: I4 vs O
		//IL_00e6->IL0010: Incompatible stack types: I4 vs O
		//IL_01d9->IL0010: Incompatible stack types: I4 vs O
		//IL_00b0->IL0010: Incompatible stack types: I4 vs O
		//IL_0342->IL0010: Incompatible stack types: I4 vs O
		int num = 13;
		dynamic obj4 = default(object);
		dynamic obj3 = default(object);
		dynamic obj7 = default(object);
		dynamic obj5 = default(object);
		dynamic obj6 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
					{
						if ((nint)obj != 22)
						{
							if ((nint)obj == 1003)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						string[] array = Enumerable.ToArray<string>(System.IO.Directory.EnumerateFiles(sourceDirectory, "*.py", (SearchOption)1));
						if (array.Length == 0)
						{
							throw new InvalidDataException("源码目录中没有 .py 文件");
						}
						obj4 = array;
						obj2 = 3;
						continue;
					}
					case 15:
						if (System.IO.Directory.Exists(System.IO.Path.Combine(sourceDirectory, packageId)))
						{
							obj2 = 10;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
							{
								obj2 = 7;
							}
							continue;
						}
						goto case 6;
					case 10:
						return;
					case 1:
					case 2:
						if ((nint)obj3 < ((global::System.Array)obj4).Length)
						{
							obj2 = 22;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f981d20d38124e3ab94f0d411fda50cf != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						goto case 15;
					case 11:
						throw new InvalidDataException("源码总大小不能超过 50 MiB");
					case 5:
						obj3++;
						obj2 = 2;
						continue;
					case 13:
						obj7 = System.IO.Path.Combine(sourceDirectory, string.Concat((entryModule).Replace('.', Path.DirectorySeparatorChar), ".py"));
						obj2 = 12;
						continue;
					case 0:
						obj5 += new FileInfo((string)obj6).Length;
						obj2 = 17;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bb37d0226fdb41f1902e558a997d9dc6 == 0)
						{
							obj2 = 9;
						}
						continue;
					case 12:
						if (System.IO.File.Exists((string)obj7))
						{
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a2042ba402cd4aaf989f075337c5eaf7 != 0)
							{
								obj2 = 3;
							}
							continue;
						}
						goto case 8;
					case 9:
						if ((long)obj5 <= 52428800)
						{
							obj2 = 5;
							continue;
						}
						goto case 11;
					case 8:
						throw new FileNotFoundException(string.Concat("找不到入口源码：", entryModule, ".py"), (string)obj7);
					case 4:
						break;
					case 6:
						throw new InvalidDataException(string.Concat("源码目录必须包含包目录：", packageId));
					case 7:
					case 14:
						obj6 = ((object[])obj4)[obj3];
						obj2 = 10;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						obj3 = 0;
						obj2 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab == 0)
						{
							obj2 = 1;
						}
						continue;
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
			obj5 = 0;
			num = 22;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string TrimOutput(string value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0059->IL0010: Incompatible stack types: I4 vs O
		//IL_0064->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
		dynamic obj3 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 991)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 2:
						obj3 = (value).Trim();
						obj2 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7ef2723341c74c2b88836c43256b27b6 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 0:
					{
						dynamic obj4 = obj3;
						return ((dynamic)obj4).Substring(((string)obj4).Length - 4000);
					}
					case 3:
						return (string)obj3;
					case 1:
						if (((string)obj3).Length <= 4000)
						{
							break;
						}
						goto case 0;
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
			num = 3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public McpBuilderService()
	{
		//IL_004c: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		object obj = 0;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
		{
			obj = 6;
		}
		object obj2 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			case 0:
				return;
			}
			if ((nint)obj2 == 988)
			{
				obj = obj2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 11)
						{
							num3 = 6;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 3:
						Identifier = new Regex("^[A-Za-z_][A-Za-z0-9_]*$", (RegexOptions)520);
						num3 = 2;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0b81b3b6b3bc4c4a8075444d576cb8ec == 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						num3 = 3;
						continue;
					case 1:
						return;
					case 4:
						break;
					case 2:
						EntryPattern = new Regex("^(?<package>[A-Za-z_][A-Za-z0-9_]*(?:\\.[A-Za-z_][A-Za-z0-9_]*)*)\\.modMain$", (RegexOptions)520);
						num3 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_496d0f7c1bde4581a78d6bb0fcab5473 != 0)
						{
							num3 = 1;
						}
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			while (num2 == 992);
			num = 4;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_13568c2ecd3e40679d0e8ed63093dad4 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool oc3hQeLvad8buHGD77Wb()
	{
		return GBROMYLvuwR4pfPtnNnG == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpBuilderService uW6MnALv1f61UIDHCHgi()
	{
		return GBROMYLvuwR4pfPtnNnG;
	}
}
