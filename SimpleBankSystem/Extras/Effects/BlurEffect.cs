using System;
using System.Windows;
using System.Threading;
using System.Windows.Media.Effects;
using SimpleBankSystem.Extras;

namespace MVVM_WPF_BankApp.Models
{
    class BlurEffectOwn
    {

        Window aimWindow = null;

        BlurEffect blurEffect = new BlurEffect();
        public void Simulator()
        {
            for (int i = 0; i <= 3; ++i)
            {
                Thread.Sleep(500);
            }
        }
        public void LoadingEffect()
        {
            blurEffect.Radius = 10;
            Effect Effect = blurEffect;
            using (Loading loading = new Loading(Simulator))
            {
                loading.Owner = aimWindow;
                loading.ShowDialog();
            }
            blurEffect.Radius = 0;
            Effect = blurEffect;
        }
        public BlurEffectOwn(Window aimWindow)
        {
            this.aimWindow = aimWindow;
        }
    }
}