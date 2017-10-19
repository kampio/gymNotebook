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

        void AddTraining(Training training, string userID);

        Training DeleteTraining(int trainingID);
    }
}
