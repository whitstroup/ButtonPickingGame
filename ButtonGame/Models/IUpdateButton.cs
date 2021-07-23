using System;
namespace ButtonGame.Models
{
    public interface IUpdateButton
    {

        public void GenerateBad();

        public void Choice(int guess);

        public void ScoreIncrease();

        public void ScoreReset();


    }
}
