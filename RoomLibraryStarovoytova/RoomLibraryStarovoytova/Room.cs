using System;

namespace RoomLibraryStarovoytova
{
    public class Room
    {
        double roomLength; //длина комнаты
        double roomWidth; //ширина комнаты
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// метдо вычисляет число квадратных метров на одного человека
        /// </summary>
        /// <param name="np">число человек</param>
        /// <returns>возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }
}
