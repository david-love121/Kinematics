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
using Projectile_Motion;
using Utility;

namespace Visualizer.Kinematics
{
    static internal class KinematicsDriver
    {
        static DongUtility.Vector ConvertVector(Utility.Vector v)
        {
            return new DongUtility.Vector(v.X, v.Y, v.Z);
        }
        static internal void RunKinematics()
        {
            World world = new World();
            Utility.Vector initialV = new Utility.Vector(Math.Cos(45) * 5, 0, Math.Sin(45) * 5);
            Utility.Vector initialA = new Utility.Vector(0, 0, -9.8);
            var projectile = new Projectile(initialV, initialA, 0, 0, 0);
            world.AddProjectile(projectile);
            var adapter = new EngineAdapter(world);

            var visualization = new KinematicsVisualization(adapter);

            Timeline.MaximumPoints = 5000;

            var fullViz = new MotionVisualizer3DControl(visualization);

            fullViz.TimeIncrement = .01;

            fullViz.Manager.Add3DGraph("Position", () => world.Time, () => ConvertVector(world.Projectiles[0].Position), "Time (s)", "Position (m)");
            fullViz.Manager.Add3DGraph("Velocity", () => world.Time, () => ConvertVector(world.Projectiles[0].TotalVelocity), "Time (s)", "Velocity (m/s)");
            fullViz.Manager.Add3DGraph("Acceleration", () => world.Time, () => ConvertVector(world.Projectiles[0].TotalAcceleration), "Time (s)", "Acceleration (m/s^2)");

            fullViz.Show();
        }


    }
}
