using System;

namespace Adapter.fachada
{
    internal class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;
        private Projetor projetor;
        private TheaterLights lights;
        private Screen screen;
        private PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amplifier,
            Tuner tuner,
            DvdPlayer dvd,
            CdPlayer cd,
            Projetor projetor,
            TheaterLights lights,
            Screen screen,
            PopcornPopper popper)
        {
            this.amplifier = amplifier;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projetor = projetor;
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            screen.Down();
            projetor.On();
            projetor.WideScreenMode();
            amplifier.On();
            amplifier.Dvd = dvd;
            amplifier.SetSurroundSound();
            amplifier.Volume = 5;
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projetor.Off();
            amplifier.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }
    }
}