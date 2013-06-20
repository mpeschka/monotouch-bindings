BTOUCH=/Developer/MonoTouch/usr/bin/btouch
VERSION=1.300
all: NewRelicAgent.dll

NewRelic_iOS_Agent_$(VERSION).zip:
	@echo "You'll need to obtain a copy of NewRelic_iOS_Agent_$(VERSION).zip"
	@echo "from http://newrelic.com"
	@echo
	@open http://newrelic.com
	exit 1

libNewRelicAgent.a: NewRelic_iOS_Agent_$(VERSION).zip
	unzip $^
	cp NewRelic_iOS_Agent_$(VERSION)/NewRelicAgent.framework/NewRelicAgent libNewRelicAgent.a

NewRelicAgent.dll: Makefile AssemblyInfo.cs NewRelicAgent.cs libNewRelicAgent.a
	$(BTOUCH) -e NewRelicAgent.cs AssemblyInfo.cs --out=$@ --link-with=libNewRelicAgent.a,libNewRelicAgent.a -r:/Developer/MonoTouch/usr/lib/mono/2.1/System.dll

clean:
	-rm -f *.a *.dll
