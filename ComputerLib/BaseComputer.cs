namespace ComputerLib
{
    abstract public class BaseComputer
    {
        private GPU? gpu;
        private CPU? cpu;
        private RAM? ram;

        public void LaunchComputer()
        {
            if (gpu is null)
                throw new Exception("There is no GPU!");
            if (cpu is null)
                throw new Exception("There is no CPU!");
            if (ram is null)
                throw new Exception("There is no RAM!");

            Console.WriteLine("Cogratulation! Your computor works correctly!");
        }
        public void AddComponent(IComputerComponent computerComponent)
        {
            switch (computerComponent)
            {
                case GPU otherGPU:
                    gpu = gpu is null? otherGPU : throw new Exception("GPU is already inside!");
                    break;
                case CPU otherCPU:
                    cpu = cpu is null ? otherCPU : throw new Exception("CPU is already inside!");
                    break;
                case RAM otherRAM:
                    ram = ram is null ? otherRAM : throw new Exception("RAM is already inside!");
                    break;
                default:
                    break;
            }
        }
        public void ReplaceComponent(IComputerComponent computerComponent)
        {
            switch (computerComponent)
            {
                case GPU otherGPU:
                    gpu = gpu is not null ? otherGPU : throw new Exception("No component!");
                    break;
                case CPU otherCPU:
                    cpu = cpu is not null ? otherCPU : throw new Exception("No component!");
                    break;
                case RAM otherRAM:
                    ram = ram is not null ? otherRAM : throw new Exception("No component!");
                    break;
                default:
                    break;
            }
        }
        public void DeleteComponent(Components computerComponent)
        {
            switch (computerComponent)
            {
                case Components.GPU:
                    gpu = gpu is not null ? null : throw new Exception("No component!");
                    break;
                case Components.CPU:
                    cpu = cpu is not null ? null : throw new Exception("No component!");
                    break;
                case Components.RAM:
                    ram = ram is not null ? null : throw new Exception("No component!");
                    break;
                default:
                    break;
            }
        }
    }

    public enum Components
    {
        GPU,
        CPU,
        RAM
    }
}
