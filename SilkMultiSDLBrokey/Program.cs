using Silk.NET.Input;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

SdlWindowing.Use();

WindowOptions options = WindowOptions.Default;

IWindow       window = Window.Create(options);
IInputContext input;

window.Load += delegate {
	input = window.CreateInput();
};

window.Update += delegate {
	window.Close();
	window.Dispose();
};

window.Run();

window = Window.Create(options);

window.Load += delegate {
	input = window.CreateInput();
};

window.Update += delegate {
	window.Close();
	window.Dispose();
};

window.Run();