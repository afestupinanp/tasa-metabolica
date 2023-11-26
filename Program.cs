// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: Tasa Metabolica Basal, Version=1.2.0.0, Culture=neutral, PublicKeyToken=f35f2858f39d1a22
// MVID: A2156353-5DEB-442E-BC29-41EC26DCDE33
// Assembly location: D:\Users\Andres\Downloads\Tasa Metabolica Basal.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new btnupdate());
    }
  }
}
