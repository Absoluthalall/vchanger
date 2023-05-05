# -*- coding: utf-8 -*-

import os, sys

sys.path.insert(0, '/var/www/u2005838/data/www/vampire-changer.site/main_project')

sys.path.insert(1, '/var/www/u2005838/data/djangoenv/lib/python3.9/site-packages')

os.environ['DJANGO_SETTINGS_MODULE'] = 'main_project.settings'

from django.core.wsgi import get_wsgi_application

application = get_wsgi_application()
