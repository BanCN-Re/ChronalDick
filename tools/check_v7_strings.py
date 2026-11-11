#!/usr/bin/env python3
"""Check that recovered plaintext literals are present as UTF-16LE #US heap entries in a DLL."""
import sys

samples = [
    "startup",
    "crash",
    "protocol",
    "收到单实例激活 kind=",
    "主窗口尚未准备好接收协议激活",
    "ms-appx:///App.xaml",
    "login",
    "登录已过期，请重新登录",
    "操作失败，服务端未返回错误详情",
    "MA-PC-",
    "Assets/favicon.ico",
    "InstallPersonIdentityCertificate",
    "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\MainWindow.xaml.cs",
    "基岩版仍在运行，Chronal 已最小化并继续保持登录",
    "MinimizeForRunningBedrock",
    "ms-appx:///MainWindow.xaml",
    "Pending",
    "Injected",
    "python.exe",
    "mcp-package-tool.exe",
    "Features/McpStudio/Runtime/mcp-build-env.zip",
]

dll = sys.argv[1]
data = open(dll, "rb").read()
ok = 0
for s in samples:
    hit = s.encode("utf-16-le") in data
    ok += hit
    print("%-4s %s" % ("OK" if hit else "MISS", s[:60]))
print("---")
print("present=%d/%d" % (ok, len(samples)))
