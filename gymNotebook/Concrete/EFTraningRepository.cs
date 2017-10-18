using gymNotebook.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gymNotebook.Models;

namespace gymNotebook.Concrete
{
    public class EFTraningRepository : ITrainingRepository
    {
        public IEnumerable<Training> Trainings => throw new NotImplementedException();

        public Training DeleteTraining(int trainingID)
        {
            throw new NotImplementedException();
        }

        public void SaveTraining(Training training)
        {
            throw new NotImplementedException();
        }
    }
}