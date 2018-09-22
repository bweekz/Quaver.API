namespace Quaver.API.Maps.Processors.Difficulty
{
    public class DifficultyCalculatorKeys : DifficultyCalculator
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="map"></param>
        public DifficultyCalculatorKeys(Qua map) : base(map)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override double CalculateDifficulty(Qua map, float rate) => map.AverageNotesPerSecond(rate);
    }
}