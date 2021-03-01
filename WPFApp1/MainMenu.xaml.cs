using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu 
    {
        private String[] IMAGES = { "Images/Beauty and the Beast Test.png", "Images/Dunkirk Test.jpg", "Images/John Wick 2 Test.jpg", "Images/Pirates of the Caribbean Test.jpg" };    // images
        private static double IMAGE_WIDTH = 128;        // Image Width
        private static double IMAGE_HEIGHT = 128;       // Image Height        
        private static double SPRINESS = 0.4;		    // Control the Spring Speed
        private static double DECAY = 0.5;			    // Control the bounce Speed
        private static double SCALE_DOWN_FACTOR = 0.5;  // Scale between images
        private static double OFFSET_FACTOR = 100;      // Distance between images
        private static double OPACITY_DOWN_FACTOR = 0.4;    // Alpha between images
        private static double MAX_SCALE = 2;            // Maximum Scale


        private double _xCenter;
        private double _yCenter;

        private int _target = 0;		// Target moving position
        private double _current = 0;	// Current position
        private double _spring = 0;		// Temp used to store last moving 
        private List<Image> _images = new List<Image>();	// Store the added images

        private static int FPS = 24;                // fps of the on enter frame event
        private DispatcherTimer _timer = new DispatcherTimer(); // on enter frame simulator

        public MainMenu()
        {
            InitializeComponent();
            GlobalVariables.StoreFilmName = "Beauty and the Beast";
            ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
        }


        private void carouselwindow_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
        }

        /////////////////////////////////////////////////////        
        // Handlers 
        /////////////////////////////////////////////////////	

        // reposition the images
        void _timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _images.Count; i++)
            {
                Image image = _images[i];
                posImage(image, i);
            }


            // compute the current position
            // added spring effect
            if (_target == _images.Count)
                _target = 0;
            _spring = (_target - _current) * SPRINESS + _spring * DECAY;
            _current += _spring;
        }

        /////////////////////////////////////////////////////        
        // Private Methods 
        /////////////////////////////////////////////////////	


        // add images to the stage
        private void addImages()
        {
            for (int i = 0; i < IMAGES.Length; i++)
            {
                // get the image resources from the xap
                string url = IMAGES[i];
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(url, UriKind.Relative));

                // add and reposition the image
                LayoutRoot.Children.Add(image);
                posImage(image, i);
                _images.Add(image);
            }
        }

        // move the index
        private void moveIndex(int value)
        {
            _target += value;
            _target = Math.Max(0, _target);
            _target = Math.Min(_images.Count - 1, _target);
        }

        // reposition the image
        private void posImage(Image image, int index)
        {
            double diffFactor = index - _current;


            // scale and position the image according to their index and current position
            // the one who closer to the _current has the larger scale
            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = MAX_SCALE - Math.Abs(diffFactor) * SCALE_DOWN_FACTOR;
            scaleTransform.ScaleY = MAX_SCALE - Math.Abs(diffFactor) * SCALE_DOWN_FACTOR;
            image.RenderTransform = scaleTransform;

            // reposition the image
            double left = _xCenter - (IMAGE_WIDTH * scaleTransform.ScaleX) / 2 + diffFactor * OFFSET_FACTOR;
            double top = _yCenter - (IMAGE_HEIGHT * scaleTransform.ScaleY) / 2;
            image.Opacity = 1 - Math.Abs(diffFactor) * OPACITY_DOWN_FACTOR;

            image.SetValue(Canvas.LeftProperty, left);
            image.SetValue(Canvas.TopProperty, top);

            // order the element by the scaleX
            image.SetValue(Canvas.ZIndexProperty, (int)Math.Abs(scaleTransform.ScaleX * 100));
        }

        /////////////////////////////////////////////////////        
        // Public Methods
        /////////////////////////////////////////////////////	

        // start the timer
        public void Start()
        {
            // start the enter frame event
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / FPS);
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }


        private void ShowingsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Showings());
        }

        private void BookingButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Booking());
        }

        private void AvailablityButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Seats());
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new About());
        }

        private void ContactButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Feedback());
        }

      
        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            moveIndex(-1);
            if (_target == 0)//Beauty and the Beast
            {
                GlobalVariables.StoreFilmName = "Beauty and the Beast";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 1)//Dunkirk
            {
                GlobalVariables.StoreFilmName = "Dunkirk"; 
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 2)//John Wick 2
            {
                GlobalVariables.StoreFilmName = "John Wick 2";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 3)//Pirates of the Caribbean 5
            {
                GlobalVariables.StoreFilmName = "Pirates of the Caribbean 5";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            moveIndex(1);
            if (_target == 0)//Beauty and the Beast
            {
                GlobalVariables.StoreFilmName = "Beauty and the Beast";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 1)//Dunkirk
            {
                GlobalVariables.StoreFilmName = "Dunkirk";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 2)//John Wick 2
            {
                GlobalVariables.StoreFilmName = "John Wick 2";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 3)//Pirates of the Caribbean 5
            {
                GlobalVariables.StoreFilmName = "Pirates of the Caribbean 5";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _xCenter = 800/ 2;
            _yCenter = 600 / 2;

            addImages();
            Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.Index = _target.ToString();

            if (_target == 0)//Beauty and the Beast
            {
                Switcher.Switch(new BeautyandBeast());
                GlobalVariables.StoreFilmName = "Beauty and the Beast";
                
            }

            if (_target == 1)//Dunkirk
            {
                Switcher.Switch(new Dunkirk());
                GlobalVariables.StoreFilmName = "Dunkirk";
                ButtonFilmChoice.Content = GlobalVariables.StoreFilmName;
            }

            if (_target == 2)//John Wick 2
            {
                Switcher.Switch(new JohnWick2());
                GlobalVariables.StoreFilmName = "John Wick 2";
            }

            if (_target == 3)//Pirates of the Caribbean 5
            {
                Switcher.Switch(new PiratesoftheCaribbean5());
                GlobalVariables.StoreFilmName = "Pirates of the Caribbean";
            }
        }
    }
}
