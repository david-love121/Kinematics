using Projectile_Motion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizer.Kinematics
{
    internal class EngineAdapter : IEngine
    {
        private World engine;
        public EngineAdapter(World engine)
        {
            this.engine = engine;
        }
        public List<IProjectile> Projectiles
        {
            get
            {
                var list = new List<IProjectile>();
                foreach (var proj in engine.Projectiles)
                {
                    list.Add(new ProjectileAdapter(proj));
                }
                return list;
            }
        }

        public double Time => engine.Time;

        public bool Tick(double newTime)
        {
            double deltaTime = newTime - engine.Time;
            engine.Increment(deltaTime);
            return true;
        }
    }
}
