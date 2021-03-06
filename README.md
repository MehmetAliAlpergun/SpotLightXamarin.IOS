# SpotLightXamarin

Xamarin IOS Library that highlights ui components for tutorials or walkthroughs

Xamarin Android version: https://github.com/MehmetAliAlpergun/SpotLightXamarin

Spotlight
--------

<img src="https://github.com/MehmetAliAlpergun/SpotLightXamarin.IOS/blob/master/Screens/SpotlightIOS.gif" width="300">


Usage
--------

```c#

// first create a target 
SimpleTarget firstTarget = new SimpleTargetBuilder(this).SetPoint(FindViewById(Resource.Id.FirstView))
                                                                    .SetRadius(200f)
                                                                    .SetTitle("First title")
                                                                    .SetDescription("This description is for first view.")
                                                                    .Build();
                                                                    
// than start spotlight

Spotlight spotlight = new SpotlightBuilder(this).SetTargets(firstTarget)
                                                            .SetDuration(1000)
                                                            .SetAnimation(new DecelerateInterpolator(2f))
                                                            .Start();
                                                                    

```

TODO
--------

* Add Skip button


License
--------

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
