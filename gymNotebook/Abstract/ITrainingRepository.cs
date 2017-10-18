using gymNotebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymNotebook.Abstract
{
    public interface ITrainingRepository
    {
        IEnumerable<Training> Trainings { get; }

        void SaveTraining(Training training);

        Training DeleteTraining(int trainingID);
    }
}
