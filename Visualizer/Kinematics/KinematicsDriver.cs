using DongUtility;
using GraphControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using VisualizerControl.Shapes;
using static WPFUtility.UtilityFunctions;
using MotionVisualizer3D;
using System.IO;
using static GraphData.GraphDataManager;

namespace Visualizer.Kinematics
{
    static internal class KinematicsDriver
    {
        static internal void RunKinematics()
        {
            //var world = new World();
            //var projectile = new Projectile(initialPosition, initialVelocity, mass);
            //world.AddProjectile(projectile);

            //var adapter = new EngineAdapter(world);

            //var visualization = new KinematicsVisualization(adapter);

            //Timeline.MaximumPoints = 5000;

            //var fullViz = new MotionVisualizer3DControl(visualization);

            //fullViz.TimeIncrement = .01;

            //fullViz.Manager.Add3DGraph("Position", () => engine.Time, () => engine.Projectiles[0].Position, "Time (s)", "Position (m)");
            //fullViz.Manager.Add3DGraph("Velocity", () => engine.Time, () => engine.Projectiles[0].Velocity, "Time (s)", "Velocity (m/s)");
            //fullViz.Manager.Add3DGraph("Acceleration", () => engine.Time, () => engine.Projectiles[0].Acceleration, "Time (s)", "Acceleration (m/s^2)");

            //fullViz.Show();
        }


    }
}
