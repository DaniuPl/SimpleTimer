using ClickableTransparentOverlay;
using ImGuiNET;
using System.Diagnostics;

namespace Timer
{
    public class Renderer : Overlay
    {
        private float deltaTime = 0f;
        private bool isPause = true;

        protected override void Render()
        {
         
            deltaTime = Globals.stopwatch.ElapsedTicks / (float)Stopwatch.Frequency;

            ImGui.Begin("Timer");
            ImGui.Text("Simple Timer: (Space to Start/Stop)");
            ImGui.Text(deltaTime.ToString("F2"));

            if (ImGui.IsKeyPressed(ImGuiKey.Space))
            {
                isPause = !isPause;
                if (isPause) Globals.stopwatch.Stop(); else Globals.stopwatch.Start();

            }

            if (ImGui.Button("Restart"))
            {
                Globals.stopwatch.Restart();
                Globals.stopwatch.Stop();
                isPause = true;
            }
            
            ImGui.SameLine();

            if (ImGui.Button("Close")) Close();
            
            ImGui.End();
        }
         
    }
}
      