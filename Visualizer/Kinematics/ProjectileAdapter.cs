using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Utility;
using VisualizerControl.Shapes;

namespace Visualizer.Kinematics
{
    internal class ProjectileAdapter : IProjectile
    {
        private Projectile projectile;
        public ProjectileAdapter(Projectile projectile)
        {
            this.projectile = projectile;
        }
        public Vector3D Position => new Vector3D(projectile.Position.X, projectile.Position.Y, projectile.Position.Z);

        public Color Color => Colors.PeachPuff;

        public Shape3D Shape => new Sphere3D(3);

        public double Size => 1;
    }
}
